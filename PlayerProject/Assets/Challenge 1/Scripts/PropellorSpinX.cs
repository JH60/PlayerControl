using UnityEngine;

public class PropellorSpinX : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Propeller spin
        transform.Rotate(0, 0, 5);
    }
}
