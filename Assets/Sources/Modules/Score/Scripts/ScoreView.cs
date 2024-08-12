using TMPro;
using UnityEngine;

namespace Score
{
    internal class ScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreText;

        internal void ShowDispaly(int score)
        {
            _scoreText.text = score.ToString();
        }
    }
}
