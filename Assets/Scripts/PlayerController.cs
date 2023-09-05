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
        // 마우스의 현재위치를 불러온다.
        Vector2 newAim = value.Get<Vector2>();
        // 마우스의 현재위치는 스크린 좌표이므로 월드 좌표로 환산해준다.
        newAim = GameManager.Instance.Camera.ScreenToWorldPoint(newAim);

        Vector2 dir = (newAim - (Vector2)transform.position).normalized;
        
        if (dir.magnitude >= .9f)
        {
            CallLookEvent(dir);
        }
    }
}
