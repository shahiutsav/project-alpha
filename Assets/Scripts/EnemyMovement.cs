using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float verticalMovement;
    private float randomRotation;
    private float speed = 5;

    private float xRange = 34f;
    private float zRange = 16.6f;

    private float turnSpeed = 35;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DirectionInterval());
    }

    // Update is called once per frame
    void Update()
    {
        MovementControl();

        // Player Movement Limit
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

    IEnumerator DirectionInterval()
    {
        while (true)
        {
            verticalMovement = Random.Range(-1, 2);
            randomRotation = Random.Range(-1, 2);
            yield return new WaitForSeconds(1);
        }
    }

    void MovementControl()
    {
        
        Debug.Log(randomRotation);
        transform.Translate(Vector3.forward * Time.deltaTime * verticalMovement * speed);

        if (verticalMovement < 0 || verticalMovement > 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * randomRotation * turnSpeed);
        }
    }

    

}
