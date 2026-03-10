using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;

    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // forward movement based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);

        // car rotatation based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
