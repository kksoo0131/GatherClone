using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMove : MonoBehaviour
{
    // ���� �÷��̾ Input�� ���ؼ� �����δ�
    // Camera�� �÷��̾ ���� �����δ�.
    // �׷��� Player�� �޾Ƽ� Player�� ��ǥ�� ���� �������ߵǳ�?
    [SerializeField] private Transform _player;

    private void FixedUpdate()
    {
        MoveFixedUpdate();
    }

    public void TargetSetting(GameObject go)
    {
        _player = go.transform;
    }

    private void MoveFixedUpdate()
    {
        if (_player != null)
        {
            transform.position = new Vector3(_player.position.x, _player.position.y, transform.position.z);
        }
        else if (GameManager.Instance.Player != null)
        { 
            _player = GameManager.Instance.Player.transform;
        }
        
    }
}
