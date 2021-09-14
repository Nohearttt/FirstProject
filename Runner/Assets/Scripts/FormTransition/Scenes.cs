using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void Play(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
