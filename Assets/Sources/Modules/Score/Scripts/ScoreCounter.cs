using UnityEngine;
using DragToMerge;
using System;
using RestartGame;

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
            ScoreChanged.Invoke(_score);
            _scoreView.ShowDispaly(_score);
        }
    }
}
