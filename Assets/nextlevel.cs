using UnityEngine;
using UnityEngine.SceneManagement;
public class nextlevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<player_control>())
        {
            int currentsceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextsceneIndex = currentsceneIndex + 1;
            SceneManager.LoadScene(nextsceneIndex);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
