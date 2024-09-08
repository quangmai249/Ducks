using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }
    public void HomeScreen()
    {
        SceneManager.LoadScene("HomeScreen", LoadSceneMode.Single);
    }
    public void GamePlay()
    {
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }
    public void TipsScreen()
    {
        SceneManager.LoadScene("TipScreen", LoadSceneMode.Single);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
