using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMove : MonoBehaviour
{
    public float speed = 10.0f;
    public float JumpPower = 5.0f;
    public Rigidbody2D rb;
    public Animator animator;

    private float horizontal = 0.0f;
    private float vertical = 0;

    private bool isGrounded = false;

    public bool shouldPlay = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        /*Debug.Log(Input.GetAxis("Horizontal"));*/
        if(shouldPlay)
            horizontal = Input.GetAxis("Horizontal");

        if(horizontal > 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0 ,0, 0));
            animator.SetBool("Run", true);
            animator.SetBool("Idle", false);
        }
        else if(horizontal < 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            animator.SetBool("Run", true);
            animator.SetBool("Idle", false);
        }
        else if (Input.GetKey(KeyCode.D) == false && isGrounded)
        {
            animator.SetBool("Idle", true);
            animator.SetBool("Jump", false);
            animator.SetBool("Run", false);

        }

        if (Input.GetButton("Jump") && isGrounded && shouldPlay)
        {
            /*vertical = JumpPower;*/
            /*rb.AddForce(new Vector2(0, JumpPower));*/
            animator.SetBool("Idle", false);
            animator.SetBool("Jump", true);
            rb.velocity = new Vector2(rb.velocity.x, JumpPower);
            isGrounded = false;
        }

        if(transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void FixedUpdate()
    {
        /*rb.velocity = new Vector2(horizontal, 0) * ;*/

        /*Vector2 veloctiyVector = rb.velocity;

        veloctiyVector.x = horizontal*speed;

        rb.velocity = veloctiyVector*/;

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);


        

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}
