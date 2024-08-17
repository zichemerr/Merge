using UnityEngine;
using DragToMerge;
using System;
using YG;
using RestartGame;
using Unity.VisualScripting;

namespace Score
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private GameRestart _restart;
        [SerializeField] private DragToMergeMediator _mediator;
        [SerializeField] private ScoreView _scoreView;

        private int _score;

        public event Action<int> ScoreChanged;

        public void Init()
        {
            _score = YandexGame.savesData.Score;
			_scoreView.ShowDispaly(_score);
			_mediator.Merged += OnMerged;
			_restart.Restarted += OnRestarted;
        }

		private void OnDisable()
        {
            _mediator.Merged -= OnMerged;
			_restart.Restarted -= OnRestarted;
		}

        private void OnMerged(int reward)
        {
            if (reward < 0)
                return;

            _score += reward;
            Save(_score);
            ScoreChanged.Invoke(_score);
            _scoreView.ShowDispaly(_score);
        }

		private void OnRestarted()
		{
            Save(0);
		}

		private void Save(int score)
        {
            YandexGame.savesData.Score = score;
            YandexGame.SaveProgress();
        }
    }
}
