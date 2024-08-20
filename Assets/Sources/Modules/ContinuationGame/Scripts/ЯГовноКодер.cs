using Circe;
using System.Collections.Generic;
using UnityEngine;

namespace GameContinuation
{
    public class ЯГовноКодер : MonoBehaviour
    {
        [SerializeField] private List<Circle> _circles;

        private void Awake()
        {
            _circles = new List<Circle>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Circle circle))
            {
                _circles.Add(circle);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Circle circle))
            {
                _circles.Remove(circle);
            }
        }

        public void ХренМоржовый()
        {
            for (int i = 0; i < _circles.Count; i++)
            {
                Destroy(_circles[i].gameObject);
            }
        }
    }

}
