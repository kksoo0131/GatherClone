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
        // ���콺 ��ġ���� ������ �޾Ƽ� ������ ���Ѵ�
        float rotZ = Mathf.Atan2(_lookDirection.y, _lookDirection.x) * Mathf.Rad2Deg;   
        // ������ ������ ���밪�� 90�̻��ϋ��� 90 �����϶��� ������. -90 ~ 90, 91 ~ -91
        _spriteRenderer.flipX = Mathf.Abs(rotZ) > 90;
        
    }

}
