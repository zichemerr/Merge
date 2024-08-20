using Circe;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Finish
{
    public class FinishRoot : MonoBehaviour
    {
        [SerializeField] private FinishZone _finishZone;
        [SerializeField, Min(2)] private int _finishCircleCount = 2;

        private LoseDetection _loseDetection;
        private Action _finishAction;

        public void Init()
        {
            Time.timeScale = 1;
            _loseDetection = new LoseDetection(Finish, _finishCircleCount);
            _finishZone.Init(AddCircle, RemoveCircle);
        }

        private void AddCircle(Circle circle)
        {
            _loseDetection.AddCircle(circle);
        }

        private void RemoveCircle(Circle circle)
        {
            _loseDetection.RemoveCircle(circle);
        }

        private void Finish()
        {
            Time.timeScale = 0;
            _finishAction?.Invoke();
        }

        public List<Circle> DestroyCircless()
        {
            return _loseDetection.DestroyCircles();
        }

        public void Delay()
        {
            _loseDetection.StartDelay(3);
        }

        public void SetFinishAction(Action finish)
        {
            _finishAction = finish;
        }
    }
}
