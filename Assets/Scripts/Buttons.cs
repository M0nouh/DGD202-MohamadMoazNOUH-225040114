using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void backSceneFromCredits()
    {
        SceneManager.LoadScene(1);
    }
    public void Quitting()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene(2);
    }

}
