using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private PlayerController _controller;
    private Vector2 _moveDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    [SerializeField] float speed = 5f;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += ChangeDirection;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void ChangeDirection(Vector2 direction)
    {
        _moveDirection = direction;
    }

    private void Move()
    {
        _rigidbody.velocity = _moveDirection * speed;
    }
}
