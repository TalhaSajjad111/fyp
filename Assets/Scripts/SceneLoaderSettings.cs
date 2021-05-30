using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoaderSettings : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
