using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_control : MonoBehaviour
{
    public Rigidbody2D rb;

    public float movespeed = 1;

    public Vector2 moveInput;

    private Animator animator;

    private SpriteRenderer playerSR;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        animator = gameObject.GetComponent<Animator>();

        playerSR = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (moveInput == Vector2.right)
        {
            animator.SetBool("walk_left", true);

            playerSR.flipX = false;
        }
        else if (moveInput == Vector2.left)
        {
            animator.SetBool("walk_left", true);

            playerSR.flipX = true;
        }
        else if (moveInput == Vector2.up)
        {
            animator.SetBool("walk_up", true);

        }
        else if (moveInput == Vector2.down)
        {
            animator.SetBool("walk_down", true);
        }
        else
        {

        }



    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (moveInput * movespeed * Time.fixedDeltaTime));
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
