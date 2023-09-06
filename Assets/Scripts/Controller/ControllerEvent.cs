using System;
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

    // ��Ʈ���ؼ� �����̴� ��ü��

    // �ڵ����� �����̴� ��ü�� ������.
}
