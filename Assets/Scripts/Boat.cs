using UnityEngine;
using UnityEngine.InputSystem;

public class Boat : MonoBehaviour
{
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Create a Vector3 to assign a mouse position to.
        //Setting the y-axis of the mouse position to an assigned value to have the boat always remain on top of the water.
        //Assigned the x value of worldMousePosition so that it is always in the oppsoite direction of the actual mouse position.
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        
        worldMousePosition.x *= -1f;
        worldMousePosition.y = -0.26f;
        worldMousePosition.z = 5f;
        
        transform.position = worldMousePosition;
    }
}
