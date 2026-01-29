using UnityEngine;

public class Fish : MonoBehaviour
{
    public float speed;
    public float xMax;
    public float xMin;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Setting Limitations for fish so it will not bounce off screen
        xMax = Screen.width;
        xMin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        moverXPos.x += speed * Time.deltaTime;
        transform.position = moverXPos;

        Vector3 screenTransformPosition = gameCamera.WorldToScreenPoint(transform.position);

        //if fish is about to go over either side of the screen, reverse the direction
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
