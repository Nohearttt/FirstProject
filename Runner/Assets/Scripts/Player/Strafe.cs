using UnityEngine;

public class Strafe : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _strafeSpeed;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>(); 
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(_strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(-_strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
