using UnityEngine;
using Score;
using YG;

namespace Record
{
    public class RecordCounter : MonoBehaviour
    {
        [SerializeField] private RecordView _recordView;
        [SerializeField] private ScoreCounter _scoreCounter;

        private int _record;

        public void Init()
        {
            _record = YandexGame.savesData.Record;
            _recordView.ShowDispaly(_record);
            _scoreCounter.ScoreChanged += OnScoreChanged;
        }

        private void OnDisable()
        {
            _scoreCounter.ScoreChanged -= OnScoreChanged;
        }

        private void OnScoreChanged(int score)
        {
            if (score <= _record)
                return;

            _record = score;
            _recordView.ShowDispaly(_record);
            YandexGame.savesData.Record = _record;
            YandexGame.SaveProgress();
        }
    }
}
