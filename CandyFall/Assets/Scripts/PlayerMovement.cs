using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _horizontalSpeed = 1f;
    [SerializeField] private float _jumpPower = 1f;
    [SerializeField] private float _fallMultiplier = 1f;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * _horizontalSpeed, _rigidbody2D.velocity.y);

        if ((Input.GetAxis("Vertical") > 0) && (_rigidbody2D.velocity.y == 0))
        {
            _rigidbody2D.velocity += Vector2.up * _jumpPower;
        }

        if (_rigidbody2D.velocity.y < 0)
        {
            _rigidbody2D.velocity += Vector2.up * Physics2D.gravity.y * (_fallMultiplier - 1) * Time.fixedDeltaTime;
        }
    }
}
