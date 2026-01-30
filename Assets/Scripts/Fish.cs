using UnityEngine;

public class Fish : MonoBehaviour
{
    private float xMax;
    private float xMin;
    public float speed;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Setting Limitations for fish so it will bounce between two designated points within the screen
        xMax = 900f;
        xMin = 200f;

        //Need to create a Vector3 which will embody the values of transform.position
        Vector3 moverXPos = transform.position;
        moverXPos.x += speed * Time.deltaTime;
        transform.position = moverXPos;

        //Enables world space to be effectively viewed in screen space
        Vector3 screenTransformPosition = gameCamera.WorldToScreenPoint(transform.position);

        //if fish is about to go over either of the designated values for XMax or XMin, reverse the direction
        if (xMax < screenTransformPosition.x)
        {
            speed *= -1;
        }

        if (xMin > screenTransformPosition.x)
        {
            speed *= -1;
        }
    }
}
