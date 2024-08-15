using UnityEngine;
using DragToMerge;
using System;
using YG;

namespace Score
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private DragToMergeMediator _mediator;
        [SerializeField] private ScoreView _scoreView;

        private int _score;

        public event Action<int> ScoreChanged;

        public void Init()
        {
            _score = Load();
            _mediator.Merged += OnMerged;
        }

        private void OnDisable()
        {
            _mediator.Merged -= OnMerged;
        }

        private void OnMerged(int reward)
        {
            if (reward < 0)
                return;

            _score += reward;
            Save();
            ScoreChanged.Invoke(_score);
            _scoreView.ShowDispaly(_score);
        }

        private void Save()
        {
            YandexGame.savesData.Score = _score;
            YandexGame.SaveProgress();
        }

        private int Load() => YandexGame.savesData.Score;
    }
}
