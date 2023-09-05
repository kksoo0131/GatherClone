using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerEvent : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    // 컨트롤해서 움직이는 객체와

    // 자동으로 움직이는 객체가 나뉜다.
}
