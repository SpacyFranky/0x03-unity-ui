using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // loads the maze scene when the Play button is pressed
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }
}
