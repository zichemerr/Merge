using UnityEngine;
using TMPro;

namespace ValueView
{
    public class ValueDisplay : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _valueText;

        public void ShowDisplay(int value)
        {
            _valueText.text = value.ToString();
        }
    }
}
