using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    //public float mouseSensitivity = 100f;
    public Rigidbody rb;
    // public float v3;
    private Vector3 offset;
    //float xRotation = 0f;
   // float yRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        rb = player.GetComponent<Rigidbody>();
        offset = transform.position - player.transform.position;
    }


    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

    }
    void Update()
    {

       // float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
       // float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

       // xRotation -= mouseY;
       // yRotation += mouseX;
       // xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        //transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);


    }
}
