using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMovement : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        //add (0,0,1) * speed to the position of the object - teleports forward ignoring collisions
        transform.position = transform.position + (Vector3.forward * speed * Time.deltaTime);
    }
}
