using Drag;
using UnityEngine;
using Circe;

namespace Merging
{
    public class MergeSystem : MonoBehaviour
    {
        public bool TryMergeItems(MergableItem firstItem, MergableItem secondItem, out MergableItem newItem)
        {
            if (firstItem.Compare(secondItem) && firstItem.HasNextTier)
            {
                newItem = Merge(firstItem, secondItem);
                return true;
            }

            newItem = null;
            return false;
        }

        private MergableItem Merge(MergableItem firstItem, MergableItem secondItem)
        {
            MergableItem newItem = firstItem.CreateNextTierInstance();
            newItem.GetComponent<Circle>().SetPosition(firstItem.transform.position);
            newItem.GetComponent<Dragable>().Disable();

            firstItem.Destroy();
            secondItem.Destroy();

            return newItem;
        }
    }
}
