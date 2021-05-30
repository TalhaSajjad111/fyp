using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderStartMenu : MonoBehaviour
{
    public void Story()
    {
        //int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("STORY");
    }
    public void Versus()
    {
        SceneManager.LoadScene("VERSUS");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Setting Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
