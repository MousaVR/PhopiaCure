using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScenes : MonoBehaviour
{
    [SerializeField] float timeToWait;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadOriginalScene", timeToWait);
    }

    void LoadOriginalScene()
    {
        SceneManager.LoadSceneAsync("Flat");
    }

}
