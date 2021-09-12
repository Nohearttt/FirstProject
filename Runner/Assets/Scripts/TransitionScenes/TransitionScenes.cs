using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScenes : MonoBehaviour
{
    public void Transition(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }    
}
