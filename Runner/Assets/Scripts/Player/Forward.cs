using UnityEngine;

public class Forward : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _forwardSpeed;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();  
    }
    private void FixedUpdate()
    {
        _rb.MovePosition(transform.position + Vector3.forward * _forwardSpeed * Time.deltaTime);
    }
}
