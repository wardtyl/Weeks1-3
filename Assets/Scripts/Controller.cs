using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public float rotationSpeed;
    public float moveSpeed;
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool leftIsHeld = Mouse.current.leftButton.isPressed;
        if(leftIsHeld )
        {
            Debug.Log("left mouse is held");
        }
        bool leftIsPressed = Mouse.current.leftButton.wasPressedThisFrame;
        if(leftIsPressed ) {
            Debug.Log("Left mouse is pressed.");
        }

        bool leftIsReleased = Mouse.current.leftButton.wasReleasedThisFrame;
        if (leftIsReleased)
        {
            Debug.Log("Left mouse is released.");
        }
      //bool spaceIsPressed = Keyboard.current.spaceKey.isPressed;

        bool upIsPressed = Keyboard.current.upArrowKey.isPressed;
        if (upIsPressed)
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }
       
        bool downIsPressed = Keyboard.current.downArrowKey.isPressed;
        if (downIsPressed)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }
        bool leftArrowIsPressed = Keyboard.current.leftArrowKey.isPressed;
        if (leftArrowIsPressed)
        {
            transform.eulerAngles += transform.forward * rotationSpeed * Time.deltaTime;
        }

        bool rightArrowIsPressed = Keyboard.current.rightArrowKey.isPressed;
        if (rightArrowIsPressed)
        {
            transform.eulerAngles -= transform.forward * rotationSpeed * Time.deltaTime;
    }
}
}
