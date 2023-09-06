using UnityEngine;

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

    private void MoveFixedUpdate()
    {
        if (_player != null)
        {
            transform.position = new Vector3(_player.position.x, _player.position.y, transform.position.z);
        }
        else if (PlayerManager.Instance.MyPlayer != null)
        { 
            _player = PlayerManager.Instance.MyPlayer.transform;
        }
        
    }
}
