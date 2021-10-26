using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float verticalBoundary = 25;
    private float horizontalBoundary = 40;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy();
    }

    private void Destroy()
    {
        if (transform.position.z > verticalBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -verticalBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > horizontalBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -horizontalBoundary)
        {
            Destroy(gameObject);
        }
    }
}
