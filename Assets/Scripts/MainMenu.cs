using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    // Public variable to store the PlayButton UI gameobject
    public Button play;
    // Public variable to store the QuitButton UI gameobject
    public Button quit;

    void Start()
    {
        PlayMaze();
        QuitMaze();
    }
    
    // loads the maze scene when the Play button is pressed
    public void PlayMaze()
    {
        play.onClick.AddListener(() => SceneManager.LoadScene("maze"));
    }

    // Closes the game window when the Quit button is pressed
    public void QuitMaze()
    {
        quit.onClick.AddListener(QuitOnClick);
    }

    public void QuitOnClick()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
