using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float fowardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        // We turn the vehicles
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
