using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Looker : MonoBehaviour
{
    public float rotationSpeed;
    public float zMax;
    public float zMin;
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotating in a direction (swapping)

        ////moves object

        //Vector3 currentRotation = transform.eulerAngles;
        //currentRotation.z += rotationSpeed * Time.deltaTime;

        //transform.eulerAngles = currentRotation;

        //if (zMax < transform.eulerAngles.z)
        //{
        //    rotationSpeed *= -1;
        //}

        //if (zMin > transform.eulerAngles.z)
        //{
        //    rotationSpeed *= -1;
        //}

        //Debug.Log(transform.eulerAngles);

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        //Setting the direction we're looking in
        //To get the direction we do END - START
        transform.up = worldMousePosition - transform.position;

        //Chases the direction of the mouse.
        transform.position += transform.up * 1f * Time.deltaTime;
    }
}
