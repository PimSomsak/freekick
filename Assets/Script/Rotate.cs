using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV, torqe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV; 
        }
        if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torqe);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            rb.angularVelocity = Vector3.zero;
            rb.AddTorque(Vector3.zero);

        }

    }
}
