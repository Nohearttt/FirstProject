using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
    public PlayerMovement movement;
    public float levelRestart = 2f;

    public void EndGame()
    {
        movement.enabled = false;
        Invoke("RestartLevel", levelRestart);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
