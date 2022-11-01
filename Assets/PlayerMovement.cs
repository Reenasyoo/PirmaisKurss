using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    
    [Range(0,100)] 
    [SerializeField] private float moveSpeed = 0f;
    [SerializeField] private float jumpForce = 0f;

    private bool isGrounded = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        //int inputAxis = (int)Input.GetAxis("Horizontal");
        //int direction = 0;
        //if (inputAxis > 0)
        //{
          //  direction = 1;
        //}
        //if (inputAxis < 0)
        //{
          //  direction = -1;
        //}

        Vector3 force = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        _rigidbody.AddForce(force * moveSpeed, ForceMode.Force);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            _rigidbody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log(isGrounded);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            isGrounded = false;
            Debug.Log(isGrounded);
        }
    }
}
