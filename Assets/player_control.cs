using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_control : MonoBehaviour
{
    public Rigidbody2D rb;

    public float movespeed = 1;

    public Vector2 moveInput;

    private Animator animator;

    private SpriteRenderer playerSR;
    public GameObject attackpoint;

    public float radius;

    public float damage;

    public LayerMask enemies;

  


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



       
        animator.SetBool("walk_left", false);
        animator.SetBool("walk_up", false);
        animator.SetBool("walk_down", false);

        if (moveInput.x > 0)
        {
            animator.SetBool("walk_left", true);

            playerSR.flipX = false;
        }
        else if (moveInput.x < 0)
        {
            animator.SetBool("walk_left", true);

            playerSR.flipX = true;
        }
        else if (moveInput.y > 0)
        {
            animator.SetBool("walk_up", true);

        }
        else if (moveInput.y < 0)
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

    public void attack()
    {
 

        Collider2D[] enemy = Physics2D.OverlapCircleAll(attackpoint.transform.position, radius, enemies);

        foreach ( Collider2D enemygameobject in enemy)
        {
            Debug.Log("hit enemy");
            enemygameobject.GetComponent<enemyhealth>().health -= damage;
        }
    }


    public void endAttack()
    {
        animator.SetBool("attack_left", false);
    }

    private void OnDrawGizmosSelected()
    {
            
            Gizmos.DrawWireSphere(attackpoint.transform.position, radius);
        
           
    }

    void OnFire()
    {
        animator.SetTrigger("attack_left");
    }

 

}
