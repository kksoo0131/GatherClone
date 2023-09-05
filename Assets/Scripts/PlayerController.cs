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
        // ���콺�� ������ġ�� �ҷ��´�.
        Vector2 newAim = value.Get<Vector2>();
        // ���콺�� ������ġ�� ��ũ�� ��ǥ�̹Ƿ� ���� ��ǥ�� ȯ�����ش�.
        newAim = GameManager.Instance.Camera.ScreenToWorldPoint(newAim);

        Vector2 dir = (newAim - (Vector2)transform.position).normalized;
        
        if (dir.magnitude >= .9f)
        {
            CallLookEvent(dir);
        }
    }
}
