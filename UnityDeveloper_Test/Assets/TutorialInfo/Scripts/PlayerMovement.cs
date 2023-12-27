using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    public Vector2 turn;
    public float speed = 1;
    public float sensitivity = 1f;
    [SerializeField]public float movementSpeed = 8f;
    [SerializeField] public float jumpspeed = 10f;
    Animator animator;

    [SerializeField]Transform groundCheck;
    [SerializeField] LayerMask ground;

    float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        // For changing movement state
        if (horizontalInput > 0 || horizontalInput < 0 || verticalInput >0 || verticalInput < 0)
        {
            animator.SetBool("Running", true);
            

        }
        else
        {
            animator.SetBool("Running", false);
        }

       

       
        rb.velocity = new Vector3 (horizontalInput * -movementSpeed, rb.velocity.y, verticalInput * -jumpspeed);

       

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpspeed, rb.velocity.z);
        }


    }

    bool isGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);

    }
   
}
