using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 8f;

    private Rigidbody _rigidbody;
    private bool _isGrounded;
    private Animator _animator;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        HandleMovementInput();
    }

    void HandleMovementInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        Vector3 velocity = movement.normalized * speed;

        _animator.SetBool("Running", velocity != Vector3.zero);
        
        if (velocity != Vector3.zero)
        {
            // Поворачиваем персонаж в сторону движения
            Quaternion toRotation = Quaternion.LookRotation(velocity, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 720 * Time.deltaTime);
        }


        _rigidbody.velocity = (velocity * speed) * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        HandleJumpInput();
    }

    void HandleJumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            Vector3 jumpVelocity = new Vector3(0f, Mathf.Sqrt(2f * jumpForce * Mathf.Abs(Physics.gravity.y)), 0f);
            _rigidbody.velocity = Vector3.up * jumpVelocity.y;
            
            _animator.SetTrigger("Jump");
        }
    }

    private void OnCollisionStay(Collision other)
    {
        _isGrounded = true;
    }

    private void OnCollisionExit(Collision other)
    {
        _isGrounded = false;
    }
}
