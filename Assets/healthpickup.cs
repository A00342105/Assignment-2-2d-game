using UnityEngine;

public class healthpickup : MonoBehaviour
{
    public int healthrestore = 30;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerhealth player = collision.GetComponent<playerhealth>();

        if (player != null)
        {
            player.heal(healthrestore);
            Debug.Log("resotredhealth");

            Destroy(gameObject);
        }
    }
}
