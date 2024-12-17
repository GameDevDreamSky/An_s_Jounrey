using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void TothButton()
    {
        SceneManager.LoadScene(1);
    }

    public void IsisButton()
    {
        SceneManager.LoadScene(2);
    }

    public void SethButton()
    {
        SceneManager.LoadScene(3);
    }

    public void HathorButton()
    {
        SceneManager.LoadScene(4);
    }

    public void BastetButton()
    {
        SceneManager.LoadScene(5);
    }

    public void OsirisButton()
    {
        SceneManager.LoadScene(6);
    }

    public void AnubisButton()
    {
        SceneManager.LoadScene(7);
    }

    public void HorusButton()
    {
        SceneManager.LoadScene(8);
    }

    public void AtonButton()
    {
        SceneManager.LoadScene(9);
    }

    public void SekhmetButton()
    {
        SceneManager.LoadScene(10);
    }

    public void SechatButton()
    {
        SceneManager.LoadScene(11);
    }

    public void ReButton()
    {
        SceneManager.LoadScene(12);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MenuButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void UnPause()
    {
        Time.timeScale = 1;
    }
}
