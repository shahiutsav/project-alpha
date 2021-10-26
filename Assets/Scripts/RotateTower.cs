using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTower : MonoBehaviour
{

    public Transform CharacterTransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FollowMouseCursor();
    }

    void FollowMouseCursor()
    {
        var groundPlane = new Plane(Vector3.up, -CharacterTransform.position.y);
        var mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDistance;

        if (groundPlane.Raycast(mouseRay, out hitDistance))
        {
            var lookAtPosition = mouseRay.GetPoint(hitDistance);
            CharacterTransform.LookAt(lookAtPosition, Vector3.up);
        }
    }
}
