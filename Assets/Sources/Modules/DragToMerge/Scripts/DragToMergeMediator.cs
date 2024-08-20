using UnityEngine;
using Merging;
using System;

namespace DragToMerge
{
    public class DragToMergeMediator : MonoBehaviour
    {
        [SerializeField] private MergeSystem _mergeSystem;

        public event Action<int> Merged;
        private int _van;

        public void Merge(MergableItem firstMergableItem, MergableItem secondMergableItem, int reward)
        {
            if (_van > 0)
            {
                _van = 0;
                return;
            }

            _van++;
            bool mergeCompleted = _mergeSystem.TryMergeItems(firstMergableItem, secondMergableItem, out MergableItem newMergableItem);

            if (mergeCompleted == true)
            {
                newMergableItem.GetComponent<Jumping>().Jump(10);
                Merged?.Invoke(reward);
            }

        }
    }
}

