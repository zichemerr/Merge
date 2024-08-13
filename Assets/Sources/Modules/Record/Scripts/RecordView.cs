using TMPro;
using UnityEngine;

namespace Record
{
    internal class RecordView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreText;

        internal void ShowDispaly(int record)
        {
            _scoreText.text = record.ToString();
        }
    }
}
