using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action Pressed, Up;

    private bool _isActive = true;

    private void Update()
    {
        if (_isActive == false)
            return;

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

    public void Deactivate()
    {
        _isActive = false;
	}

    public void Activate()
    {
        _isActive = true;
    }
}
