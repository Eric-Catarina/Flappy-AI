using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private float movementSpeed = 3f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         rb.MovePosition(transform.position + Vector3.left * movementSpeed * Time.deltaTime);
    }
}
