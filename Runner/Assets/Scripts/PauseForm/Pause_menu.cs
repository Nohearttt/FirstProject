using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_menu : MonoBehaviour
{
    private static bool _gameIsPause = false;
    [SerializeField] private GameObject _pauseMenu;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(_gameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }    
    }
    public void Resume()
    {
        _pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        _gameIsPause = false;
    }
    private void Pause()
    {
        _pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        _gameIsPause = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainWindow");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
