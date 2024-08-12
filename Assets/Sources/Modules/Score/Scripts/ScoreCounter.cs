using UnityEngine;
using DragToMerge;

namespace Score
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private DragToMergeMediator _mediator;
        [SerializeField] private ScoreView _scoreView;

        private int _score;

        public void Init()
        {
            _mediator.Merged += OnMerged;
        }

        private void OnDisable()
        {
            _mediator.Merged -= OnMerged;
        }

        private void OnMerged()
        {
            _score++;
            _scoreView.ShowDispaly(_score);
        }
    }
}
