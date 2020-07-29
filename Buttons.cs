using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // button ExitGame
    public void doExitGame()
    {


        Application.Quit();
    }

    // button play 
    public void PlayGame()
    {

        SceneManager.LoadScene("Gameplay 1");

    }

    // button back to menu
    public void BackMenu()
    {

        SceneManager.LoadScene("Menu");

    }



}
