using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotateTower : MonoBehaviour
{
    public Transform CharacterTransform;

    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
    }

    void LookAtPlayer()
    {
        if (target != null)
        {
            CharacterTransform.LookAt(target);
        }
    }
}
