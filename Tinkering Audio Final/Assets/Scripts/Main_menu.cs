using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    public void PlayGame ()
        //Makes the "PLAY" button in the main menu load the "Game" scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
        //Makes the "QUIT" button in the main menu quit the game and type "QUIT" in the console.
    {
        Debug.Log("QUIT");
        Application.Quit();     
    }
}
