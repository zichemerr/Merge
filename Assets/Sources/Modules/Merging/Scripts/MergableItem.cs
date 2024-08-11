using UnityEngine;

namespace Merging
{
    public class MergableItem : MonoBehaviour
    {
        [SerializeField] private MergableItem _nextTier;
        [SerializeField] private int _tier;

        internal int Tier => _tier;
        internal bool HasNextTier => _nextTier != null;

        internal bool Compare(MergableItem comparing)
        {
            return comparing.Tier == Tier;
        }

        internal MergableItem CreateNextTierInstance()
        {
            return Instantiate(_nextTier);
        }

        internal void Destroy()
        {
            Destroy(gameObject);
        }
    }
}
