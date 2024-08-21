using UnityEngine;
using System;
using Michsky.MUIP;

namespace RestartGame
{
    internal class ButtonRestart : MonoBehaviour
    {
        [SerializeField] private ButtonManager _buttonManager;

        private Action _clickAction;

        internal void Init(Action clickAction)
        {
            _clickAction = clickAction;
        }

        private void OnEnable()
        {
            _buttonManager.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            _buttonManager.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            _clickAction?.Invoke();
        }
    }
}

