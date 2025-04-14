using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 15.0f;
    public float rotationSpeed = 15.0f;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * 15);

        // tilt the plane up/down based on up/down arrow keys

        if (verticalInput < 0) 
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed * verticalInput);

        if (verticalInput > 0)
            transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed * verticalInput);
    }
}
