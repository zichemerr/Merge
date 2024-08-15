using UnityEngine;
using Merging;
using DragToMerge;

public class MergableItemCollision : MonoBehaviour
{
    [SerializeField] private DragToMergeMediator _mediator;
    [SerializeField] private int _reward;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out MergableItem mergable))
        {
            _mediator.Merge(GetComponent<MergableItem>(), mergable, _reward);
        }
    }
}

