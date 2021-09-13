using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] public GameManager _gm;
    private Rigidbody _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            _rb.constraints = RigidbodyConstraints.FreezeAll;
            _gm.EndGame();
        }
    }
}
