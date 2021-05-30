using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoaderCharacterSelection : MonoBehaviour
{
    public void Back()
    {
        //int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("VERSUS");
    }
}
