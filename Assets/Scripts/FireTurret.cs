using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTurret : MonoBehaviour
{
    public GameObject projectilePrefab;

    private float waitTime = 0.85f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            // On spacebar press, send dog
            if (Input.GetKey(KeyCode.Mouse0))
            {
                FireProjectile();
                timer = 0;

            }

        }
    }

    void FireProjectile()
    {
        Instantiate(projectilePrefab, transform.position, transform.rotation);

    }

}
