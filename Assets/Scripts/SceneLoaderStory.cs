using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderStory : MonoBehaviour
{
   

    public void NewGame()
    {
        //int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("STORY NEW GAME");
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("STORY LOAD GAME");
    }
    public void Back()
    {
        SceneManager.LoadScene("Start Menu");
    }

}
