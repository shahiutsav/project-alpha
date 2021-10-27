using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject projectilePrefab;

    private float waitTime = 3f;
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
            FireProjectile();
            timer = 0;
        }
    }

    void FireProjectile()
    {
        Instantiate(projectilePrefab, transform.position, transform.rotation);
    }
}
