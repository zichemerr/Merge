using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action Pressed, Up;

    private void Update()
    {
        Pressed?.Invoke();

        if (Input.GetMouseButtonUp(0))
            Up?.Invoke();
    }

    public Vector2 GetCursorPosition()
    {
        Vector2 cursorPostion = Input.mousePosition;
        cursorPostion.y = transform.position.y;
        return cursorPostion;
    }
}
