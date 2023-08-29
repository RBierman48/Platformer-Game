using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    Rigidbody rb;
    public float movementSpeed = 5f;
    public float jumpForce = 6f;

    public Transform groundCheck;
    public LayerMask ground;
   
    void Start() // Start is called before the first frame update
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update() // Update is called once per frame
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy Head"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }
    }

    bool IsGrounded()
    {
       return Physics.CheckSphere(groundCheck.position,  -1f, ground);
    }

}
