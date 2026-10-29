using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
  public void Playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void quitgame()
    {
        Application.Quit();
    }    
}
