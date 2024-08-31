using UnityEngine;
using Merging;
using DragToMerge;
using Drag;

public class MergableItemCollision : MonoBehaviour
{
    [SerializeField] private DragToMergeMediator _mediator;
    [SerializeField] private int _reward;

    private Dragable _dragable;

    private void Start()
    {
        _dragable = GetComponent<Dragable>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out MergableItem mergable))
        {
            if (mergable.GetComponent<Dragable>() || _dragable != null)
                return;

            _mediator.Merge(GetComponent<MergableItem>(), mergable, _reward);
        }
    }
}

