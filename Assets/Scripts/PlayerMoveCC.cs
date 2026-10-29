using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveCC : MonoBehaviour
{
    public CharacterController cc;
    public float moveSpeed = 40.0f;
    public float rotateSpeed = 10.0f;
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    public bool onMenu = true; // Flag to check if the player is on the menu

    private Vector2 moveInput; //X and Z axis movement input
    private float riseInput; //Y axis movement input
    private Vector2 lookInput; //camera look input (rotation)

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        //Debug.Log($"Move Input: {moveInput}");
        
    }
    public void Look(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
        //Debug.Log($"Look Input: {lookInput}");

       
        

    }
    public void Rise(InputAction.CallbackContext context)
    {
        riseInput = context.ReadValue<float>();
        //Debug.Log($"Rise Input: {riseInput}");
    }

    public void ChangeScene(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main Scene");
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (onMenu) 
        {             // If the player is on the menu, do not process movement or rotation
            return;
        }

        //mouse look direction from Look function
        rotationX -= lookInput.y * rotateSpeed;
        rotationY += lookInput.x * rotateSpeed;

        if (rotationX < -90)
        {
            rotationX = -90;
        }
        else if (rotationX > 90)
        {
            rotationX = 90;
        }
        // Apply rotation to the player
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);


        // Move the player based on input from Move function (X and Z axis)
        float dx = moveInput.x * moveSpeed * Time.deltaTime;
        float dz = moveInput.y * moveSpeed * Time.deltaTime;


        float dy = riseInput * moveSpeed * Time.deltaTime;


        cc.Move(transform.TransformDirection(new Vector3(dx, dy, dz)));



    }
}
