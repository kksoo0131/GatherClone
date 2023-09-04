using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : ControllerEvent
{
    private void OnMove(InputValue value)
    {
        CallMoveEvent(value.Get<Vector2>().normalized);
    }

    private void OnLook(InputValue value) 
    {
        CallLookEvent(value.Get<Vector2>().normalized);
    }
}
