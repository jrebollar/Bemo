using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSelection : MonoBehaviour
{
    public void LoadTestScene()
    {
        SceneManager.LoadScene("TestScene");
    }
    public void LoadMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Load1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Load2()
    {
        SceneManager.LoadScene("Level2");
    }
     public void Load3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
