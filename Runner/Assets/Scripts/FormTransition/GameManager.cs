using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Forward _forwardMovement;
    [SerializeField] private Jump _jumpMovement;
    [SerializeField] private Strafe _strafeMovement;

    [SerializeField] private float _levelRestart = 2f;
    public void EndGame()
    {
        _forwardMovement.enabled = false;
        _jumpMovement.enabled = false;
        _strafeMovement.enabled = false;
        Invoke("RestartLevel", _levelRestart);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
