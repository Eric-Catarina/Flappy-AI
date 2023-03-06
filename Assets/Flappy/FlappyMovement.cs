using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    [SerializeField] private float forcaDoSoco = 7f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * forcaDoSoco, ForceMode.Impulse);
        }
    }
}
