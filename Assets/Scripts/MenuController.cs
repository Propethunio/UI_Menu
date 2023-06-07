using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void NewGamePlay(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}