using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    public LayerMask groundLayers;
    public float jumpForce = 3;



    private bool isgrounded;
    public float groundDistance;
    public Transform groundCheck;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayers);
        if (isgrounded==true && Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }
        if (isgrounded == true && Input.GetKey(KeyCode.S))
        {
           
            rb.drag = 10;
          
        }
        else
        {
            rb.drag = 0;
        }
    }

}
