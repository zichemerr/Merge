using Circe;
using System;
using System.Collections.Generic;

namespace Finish
{
    internal class LoseDetection
    {
        private readonly List<Circle> _circles;
        private readonly Action _finishAction;
        private readonly int _finishCircleCount;

        internal LoseDetection(Action finish, int finishCircleCount)
        {
            _circles = new List<Circle>();
            _finishAction = finish;
            _finishCircleCount = finishCircleCount;
        }

        internal void AddCircle(Circle circle)
        {
            _circles.Add(circle);

            if (CheckLose())
                _finishAction?.Invoke();
        }

        internal void RemoveCircle(Circle circle)
        {
            _circles.Remove(circle);
        }

        private bool CheckLose()
        {
            if (_circles.Count >= _finishCircleCount)
                return true;

            return false;
        }
    }
}
