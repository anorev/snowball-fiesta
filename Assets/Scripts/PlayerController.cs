using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10.0f;
    private float xInput;   
    private float yInput; 
    // Start is called before the first frame update, called once 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void FixedUpdate() {
        // Move
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0.0f, yInput) * speed);

    }
}
