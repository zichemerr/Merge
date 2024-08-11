using UnityEngine;
using Circe;
using System;

namespace Finish
{
    internal class FinishZone : MonoBehaviour
    {
        private Action<Circle> _enterAction;
        private Action<Circle> _exitAction;

        internal void Init(Action<Circle> enter, Action<Circle> exit)
        {
            _enterAction = enter;
            _exitAction = exit;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            SetTriggerAction(collision, _enterAction);
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            SetTriggerAction(collision, _exitAction);
        }

        private void SetTriggerAction(Collider2D collision, Action<Circle> action)
        {
            if (collision.TryGetComponent(out Circle circle))
                action?.Invoke(circle);
        }
    }
}

