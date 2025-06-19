using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingController : MonoBehaviour
{
    public float waitTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Loading", waitTime);
    }

    void LoadGameScene()
    {
        SceneManager.LoadScene("Lobby");
    }
}
