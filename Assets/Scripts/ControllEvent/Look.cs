using UnityEngine;

public class Look : MonoBehaviour
{
    private PlayerController _controller;
    private Vector2 _lookDirection = Vector2.right;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {
        _controller.OnLookEvent += LookAt;
    }

    private void FixedUpdate()
    {
        LookFixedUpdate();
    }

    private void LookAt(Vector2 direction)
    {
        _lookDirection = direction;
    }
    
    private void LookFixedUpdate()
    {
        // 마우스 위치로의 방향을 받아서 각도를 구한다
        float rotZ = Mathf.Atan2(_lookDirection.y, _lookDirection.x) * Mathf.Rad2Deg;   
        // 방향은 각도의 절대값이 90이상일떄와 90 이하일때로 나뉜다. -90 ~ 90, 91 ~ -91
        _spriteRenderer.flipX = Mathf.Abs(rotZ) > 90;
        
    }

}
