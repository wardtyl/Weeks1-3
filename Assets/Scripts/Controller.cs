using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
public class Controller : MonoBehaviour
{
    public float rotationSpeed;
    public float moveSpeed;
    public Camera gameCamera;

    public SpriteRenderer spriteRenderer;
    public Color startingColour;

    public List<SpriteRenderer> controllableRenderers;
    public List<Transform> controlledTransforms;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets color
        spriteRenderer.color = Color.red;

        bool isInsideSprite = spriteRenderer.bounds.Contains(transform.position);

        controlledTransforms.Add(transform);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        bool isLeftPressed = Mouse.current.leftButton.isPressed;
        if (isLeftPressed)
        {
            //Find any renderers that are currently hovered over

            //Iterate over all of the elements and determine if anyh of them are hovered over
            for (int i = 0; i < controllableRenderers.Count; i++)
            {
                SpriteRenderer currentSpriteRenderer = controllableRenderers[i];
                bool isHovered = currentSpriteRenderer.bounds.Contains(worldMousePosition);
                if (isHovered)
                {
                    controlledTransforms.Add(currentSpriteRenderer.transform);
                }
            }
        }

        for (int i = 0; i < controlledTransforms.Count; i++)
        {
            Transform currentTransform = controlledTransforms[i];
            bool leftArrowHeld = Keyboard.current.leftArrowKey.isPressed;
            bool rightArrowHeld = Keyboard.current.rightArrowKey.isPressed;
            bool upArrowHeld = Keyboard.current.upArrowKey.isPressed;
            bool downArrowHeld = Keyboard.current.downArrowKey.isPressed;
            if (leftArrowHeld)
            {
                currentTransform.eulerAngles += currentTransform.forward * rotationSpeed * Time.deltaTime;
            }
            if (rightArrowHeld)
            {
                currentTransform.eulerAngles -= currentTransform.forward * rotationSpeed * Time.deltaTime;
            }
            if (upArrowHeld)
            {
                currentTransform.position += currentTransform.up * moveSpeed * Time.deltaTime;
            }
            if (downArrowHeld)
            {
                currentTransform.position -= currentTransform.up * moveSpeed * Time.deltaTime;
            }
        }

        bool leftIsHeld = Mouse.current.leftButton.isPressed;
        if (leftIsHeld)
        {
            Debug.Log("left mouse is held");
        }
        bool leftIsPressed = Mouse.current.leftButton.wasPressedThisFrame;
        if (leftIsPressed)
        {
            Debug.Log("Left mouse is pressed.");
        }

        bool leftIsReleased = Mouse.current.leftButton.wasReleasedThisFrame;
        if (leftIsReleased)
        {
            Debug.Log("Left mouse is released.");
        }
        //bool spaceIsPressed = Keyboard.current.spaceKey.isPressed;

        //    bool upIsPressed = Keyboard.current.upArrowKey.isPressed;
        //    if (upIsPressed)
        //    {
        //        transform.position += transform.up * moveSpeed * Time.deltaTime;
        //    }

        //    bool downIsPressed = Keyboard.current.downArrowKey.isPressed;
        //    if (downIsPressed)
        //    {
        //        transform.position -= transform.up * moveSpeed * Time.deltaTime;
        //    }
        //    bool leftArrowIsPressed = Keyboard.current.leftArrowKey.isPressed;
        //    if (leftArrowIsPressed)
        //    {
        //        transform.eulerAngles += transform.forward * rotationSpeed * Time.deltaTime;
        //    }

        //    bool rightArrowIsPressed = Keyboard.current.rightArrowKey.isPressed;
        //    if (rightArrowIsPressed)
        //    {
        //        transform.eulerAngles -= transform.forward * rotationSpeed * Time.deltaTime;
        //}


    }
}



