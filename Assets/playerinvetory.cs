using UnityEngine;
using UnityEngine.UIElements;

public class playerinvetory : MonoBehaviour
{

    public int coins = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "collectable")
        {
            //Debug.Log("collided with: " + collision.collider.name);
            GameObject collectable = collision.gameObject;

            int collectablevalue = collectable.GetComponent<item_value>().itemvalue;

            coins += collectablevalue;

            Destroy(collectable);

            Debug.Log("coins: " + coins);
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "collectable")
        {
            Debug.Log("collided ended with: " + collision.collider.name);
        }
            
    }




}
