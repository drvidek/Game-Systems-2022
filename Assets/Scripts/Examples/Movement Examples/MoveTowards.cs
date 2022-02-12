using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{

    public float speed = 5f;
    private Vector3 newPos;
    private Vector3 moveDir;

    // Update is called once per frame
    void Update()
    {
        newPos = transform.position;
        newPos += Vector3.forward * speed * Time.deltaTime;
        moveDir = newPos - transform.position;
        transform.position = Vector3.MoveTowards(transform.position, newPos, speed);
    }
}
