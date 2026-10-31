using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public float health;
    public float currenthealth;
    private Animator animator;
    private Rigidbody2D rb;


    public bool isdead;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        currenthealth = health;
    }

    // Update is called once per frame
    void Update()
    {


        if (health <= 0 && !isdead)
        {
            isdead = true;
            animator.SetBool("death", true);

            rb.simulated = false;
        }
    }
}