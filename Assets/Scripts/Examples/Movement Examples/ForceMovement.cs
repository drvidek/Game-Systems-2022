using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rigBody;

    private void Start()
    {
        rigBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigBody.AddForce(Vector3.forward * speed);
    }
}
