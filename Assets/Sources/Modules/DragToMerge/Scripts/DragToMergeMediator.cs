using Drag;
using UnityEngine;
using Merging;

namespace DragToMerge
{
    public class DragToMergeMediator : MonoBehaviour
    {
        [SerializeField] private DragRoot _dragRoot;
        [SerializeField] private MergeSystem _mergeSystem;

        private int _van;

        public void Merge(MergableItem firstMergableItem, MergableItem secondMergableItem)
        {
            if (_van > 0)
            {
                _van = 0;
                return;
            }

            _van++;
            bool mergeCompleted = _mergeSystem.TryMergeItems(firstMergableItem, secondMergableItem, out MergableItem newMergableItem);

            if (mergeCompleted == true)
                newMergableItem.GetComponent<Jumping>().Jump(3);
        }
    }
}

