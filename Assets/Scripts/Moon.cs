using UnityEngine;
using UnityEngine.InputSystem;

public class Moon : MonoBehaviour
{
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Created Vector 3 ensures that the object coordinates its own position with the mouse position. 
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        //Ensures object is visible on game screen and stays on the designated y-value while still following the mouse.
        worldMousePosition.y = 3.4f;
        worldMousePosition.z = 1;
        transform.position = worldMousePosition;
    }
}
