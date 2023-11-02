using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{

    public float moveSpeed = 3f;
    Rigidbody rb;
    Vector3 moveDir = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {

        moveDir.x = Input.GetAxisRaw("Horizontal");
        moveDir.z = Input.GetAxisRaw("Vertical");

        /*
        Vector3 moveDir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        rb.velocity = moveDir * moveSpeed;
        */



    }
    private void FixedUpdate()
    {
        moveDir.y = 0;
        moveDir = moveDir.normalized * (moveSpeed);
        moveDir.y = rb.velocity.y;
        rb.velocity = moveDir;
    }
}
