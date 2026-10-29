using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float rotationX;
    public float rotationY;
    public float rotationZ;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("MainCamera").transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);

        //hide cursor and lock it to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    void Update()
    {
        rotationX -= Input.GetAxis("Mouse Y") * Time.deltaTime * rotationSpeed;
        rotationY += Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed;

        if (rotationX < -90)
        {
            rotationX = -90;
        }
        else if (rotationX > 90)
        {
            rotationX = 90;
        }
        transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);

    }
    // Update every 0.2 seconds?
    void FixedUpdate()
    {
        if (Input.GetKey("w") && !Input.GetKey("s")) //walk forwards
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("s") && !Input.GetKey("w")) //walk backwards
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("a") && !Input.GetKey("d")) //cancel left and right if both buttons pressed
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("space") && !Input.GetKey(KeyCode.LeftShift)) //cancel up and down if both buttons pressed
        {
            transform.position += transform.TransformDirection(Vector3.up) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftShift) && !Input.GetKey("space"))
        {
            transform.position -= transform.TransformDirection(Vector3.up) * Time.deltaTime * movementSpeed;
        }

    }
}