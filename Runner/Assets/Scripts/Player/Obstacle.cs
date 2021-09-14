using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject _dieMenu;
    private bool _gamePause = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            if (_gamePause)
            {
                Restart();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Restart()
    {
        _gamePause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void Pause()
    {
        _dieMenu.SetActive(true);
        Time.timeScale = 0f;
        _gamePause = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainWindow");
    }
}
