using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // 나는 플레이어를 Input을 통해서 움직인다
    // Camera는 플레이어를 따라 움직인다.
    // 그러면 Player를 받아서 Player의 좌표에 따라 움직여야되나?
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
