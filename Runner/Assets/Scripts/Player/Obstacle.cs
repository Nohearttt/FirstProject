using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] public GameManager _gm;
    private Rigidbody _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            _rb.constraints = RigidbodyConstraints.FreezeAll;
            _gm.EndGame();
            Debug.Log("Конец игры");
        }
    }



}
