using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enemyagrozone : MonoBehaviour
{
    public GameObject target;
    public GameObject enemy;
    public float movementspeed;

    private Rigidbody2D enemyrigidbody;
   private Vector2 calculatedirection;
    private bool targetdetected = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyrigidbody = enemy.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (targetdetected)
        {
            calculatedirection = (target.transform.position - enemy.transform.position).normalized;
            enemyrigidbody.linearVelocity = calculatedirection * movementspeed;
        }
        else
        {
            enemyrigidbody.linearVelocity = new Vector2(0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals(target.name))
        {
            targetdetected = true;
        }
        //Debug.Log("Enter: " + collision.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name.Equals(target.name))
        {
            targetdetected = false;
        }
           // Debug.Log("Exit: " + collision.name);
       
    }

}
