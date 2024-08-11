using UnityEngine;
using UnityEngine.UI;
using System;

namespace RestartGame
{
    internal class ButtonRestart : MonoBehaviour
    {
        [SerializeField] private Button _button;

        private Action _clickAction;

        internal void Init(Action clickAction)
        {
            _clickAction = clickAction;
            _button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            _clickAction?.Invoke();
        }

        internal void Enable()
        {
            gameObject.SetActive(true);
        }
    }
}

