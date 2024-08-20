using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Jumping : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;

    public void Jump(float force)
    {
        _rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }
}
