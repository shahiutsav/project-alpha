using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 3;
    private float turnSpeed = 35;

    // Object for projectile

    // Input from players
    private float forwardInput;
    private float horizontalInput;

    private float xRange = 34f;
    private float zRange = 16.6f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        KeyboardControls();
        

    }

    void KeyboardControls()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * -speed);
        Debug.Log(transform.position);
        if (forwardInput < 0 || forwardInput > 0 )
        {
            transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * turnSpeed);
        }




        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        else if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }
}
