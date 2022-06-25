using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 15f;
    public string groundTag = "Ground";
    private Rigidbody2D rb;
    private float vertical;
    private float horizontal;
    bool isGrounded = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        
        if(isGrounded)
        {
            if(Input.GetButtonDown("Jump"))
            {
                /*vertical = */
            }
        }
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = horizontal;
        rb.velocity = velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == groundTag)
        {
            isGrounded = true;
        }
    }
}
