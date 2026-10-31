using UnityEngine;

public class continiusshooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletpos;
    private float timer;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);
        if (distance < 5)
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                timer = 0;
                shoot();
            }
        }
    }
    void shoot()
    {
        Instantiate(bullet, bulletpos.position, Quaternion.identity);
    }
}
