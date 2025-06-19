using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void LoadGameScene()
    {
        // Load the game scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level Design");
    }
}
