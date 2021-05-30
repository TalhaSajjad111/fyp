using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoaderVersus : MonoBehaviour
{
    
         public void PvsC()
    {
        //int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Character Selection");
    }
    public void PvsPBlutooth()
    {
        SceneManager.LoadScene("Character Selection");
    }
    public void Back()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
