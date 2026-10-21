using UnityEngine;
using UnityEngine.UI;
public class playerhealth : MonoBehaviour
{

    public float health;
    public float maxhealth;
    public Image healthbar;
    private Animator animator;
    private SpriteRenderer playerSR;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxhealth = health;

        animator = gameObject.GetComponent<Animator>();

        playerSR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       

        healthbar.fillAmount = Mathf.Clamp(health / maxhealth, 0, 1);

        if(health <= 0)
        {
            animator.SetBool("death", true);

        }
    }

}
