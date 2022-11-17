using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    Scene mainMenu;

    Scene gameScene;


    public void RestartGame()
    {
        gameScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(gameScene.name);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
