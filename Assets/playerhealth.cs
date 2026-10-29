using UnityEngine;
using UnityEngine.UI;
public class playerhealth : MonoBehaviour
{

    public float health;
    public float maxhealth;
    public Image healthbar;
    private Rigidbody2D rb;

    public gamemanager gamemanager;

 

    private bool isdead;
    private Animator animator;
    private SpriteRenderer playerSR;

  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();

        maxhealth = health;

        animator = gameObject.GetComponent<Animator>();

        playerSR = gameObject.GetComponent<SpriteRenderer>();

       
    }

    // Update is called once per frame
    void Update()
    {
       

        healthbar.fillAmount = Mathf.Clamp(health / maxhealth, 0, 1);

        if(health <= 0 && !isdead)
        {
            isdead = true;
            
            gamemanager.gameOver();
            animator.SetBool("death", true);

            rb.simulated = false;

        }

    }

}
