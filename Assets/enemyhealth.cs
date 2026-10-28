using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public float health;
    public float currenthealth;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        currenthealth = health;
    }

    // Update is called once per frame
    void Update()
    {
  

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}