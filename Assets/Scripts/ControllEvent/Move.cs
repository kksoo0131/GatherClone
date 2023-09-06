using UnityEngine;

public class Move : MonoBehaviour
{
    private PlayerController _controller;
    private Vector2 _moveDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    private Animator _anim;
    [SerializeField] float speed = 10f;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += MoveDir;
    }

    private void FixedUpdate()
    {
        MoveFixedUpdate();
        MoveAnimation();
    }

    private void MoveDir(Vector2 direction)
    {
        _moveDirection = direction;
    }

    private void MoveFixedUpdate()
    {
        _rigidbody.velocity = _moveDirection * speed;
    }

    private void MoveAnimation()
    {
        if (_anim == null)
        {
            _anim = GetComponentInChildren<Animator>();
        }

        if (_rigidbody.velocity == Vector2.zero)
        {
            _anim.SetBool("isWalk", false);
        }
        else 
        {
            _anim.SetBool("isWalk", true);
        }
    }


}
