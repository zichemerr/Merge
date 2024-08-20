using Circe;
using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Finish
{
    internal class LoseDetection
    {
        private readonly Action _finishAction;
        private readonly int _finishCircleCount;

        private List<Circle> _circles;
        private bool _isActive = true;

        internal List<Circle> Circles => _circles;

        internal LoseDetection(Action finish, int finishCircleCount)
        {
            _circles = new List<Circle>();
            _finishAction = finish;
            _finishCircleCount = finishCircleCount;
        }

        internal void AddCircle(Circle circle)
        {
            if (_isActive == false)
                return;

            _circles.Add(circle);

            if (CheckLose())
                _finishAction?.Invoke();
        }

        internal IEnumerator StartDelay(int delay)
        {
            _isActive = false;
            yield return new WaitForSeconds(delay);
            _isActive = true;
        }

        internal void RemoveCircle(Circle circle)
        {
            _circles.Remove(circle);
        }

        internal List<Circle> DestroyCircles()
        {
            List<Circle> list = new List<Circle>();

            foreach (var item in _circles)
            {
                list.Add(item);
                _circles.Remove(item);
            }  

            return list;
        }

        private bool CheckLose()
        {
            if (_circles.Count >= _finishCircleCount)
                return true;

            return false;
        }
    }
}
