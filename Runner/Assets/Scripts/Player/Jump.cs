using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] float _jumpSpeed;
    [SerializeField] private bool _isGround;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void JumpLogic(Vector3 direction)
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (_isGround)
            {
                _rb.AddForce(direction * _jumpSpeed);
            }
        }
    }

    private void IsGroundedUpate(Collision collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            _isGround = value;
        }
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsGroundedUpate(collision, false);
        }
    }
    private void FixedUpdate()
    {
        JumpLogic(Vector3.up);
    }

}
