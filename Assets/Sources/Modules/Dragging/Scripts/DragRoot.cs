using UnityEngine;
using Circe;

namespace Drag
{
    public class DragRoot : MonoBehaviour
    {
        [SerializeField] private PlayerInput _input;

        private Dragable _dragable;

        public void Init()
        {
            _input.Pressed += OnPressed;
            _input.Up += OnUp;
        }

        private void OnDisable()
        {
            _input.Pressed -= OnPressed;
            _input.Up -= OnUp;
        }

        public void SetDragable(Circle circle)
        {
            _dragable = circle.GetComponent<Dragable>();
        }

        private void OnPressed()
        {
            if (CheckDraggableCount())
                return;

            _dragable.Drag(_input.GetCursorPosition());
        }

        private void OnUp()
        {
            if (CheckDraggableCount())
                return;

            _dragable.Disable();
            _dragable = null;
        }

        private bool CheckDraggableCount()
        {
            if (_dragable == null)
                return true;

            return false;
        }
    }
}
