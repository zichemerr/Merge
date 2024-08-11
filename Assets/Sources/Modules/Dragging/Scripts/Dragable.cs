using UnityEngine;

namespace Drag
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Dragable : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private Collider2D _collider;
        [SerializeField] private float _maxPosition;
        [SerializeField] private float _minPosition;

        private Vector2 SetFrames(Vector2 newPosition)
        {
            if (newPosition.x > _maxPosition)
                newPosition.x = _maxPosition;

            if (newPosition.x < _minPosition)
                newPosition.x = _minPosition;

            return newPosition;
        }

        internal void Drag(Vector2 cursorPostion)
        {
            Vector2 newPosition = Camera.main.ScreenToWorldPoint(cursorPostion);
            newPosition = SetFrames(newPosition);
            newPosition.y = transform.position.y;
            transform.position = newPosition;
        }

        internal void Disable()
        {
            _rigidbody.isKinematic = false;
            _collider.isTrigger = false;
            _rigidbody.AddForce(-Vector2.up * 8, ForceMode2D.Impulse);
            Destroy(GetComponent<Dragable>());
        }
    }
}
