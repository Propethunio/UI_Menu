using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string newGameLevel;
    private string levelToLoad;

    public void NewGamePlay()
    {
        SceneManager.LoadScene(newGameLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}