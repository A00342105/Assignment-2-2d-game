using UnityEngine;

public class enemydamage : MonoBehaviour
{
    public playerhealth plyhealth;
    public float enemydamag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<playerhealth>().health -= enemydamag;
        }
        
        
    }
}
