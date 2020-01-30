using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenButtonFunctions : MonoBehaviour
{
    public string menuScene;
    public string gameScene;

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void RestartGame()
    {
        WaveSystem.WaveNumber = 0;
        Time.timeScale = 1;
        Application.LoadLevel(Application.loadedLevel);
    }
}
