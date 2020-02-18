using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadScene", 2f); // load the scene after 2 seconds
    }

    void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
