using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Camera gameCamera;
    private float speed = 0.02f;
    private float xMax;
    private float xMin;
    private float yMax;
    private float yMin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xMax = Screen.width;
        yMax = Screen.height;
        //set xMin to whatever is too far to the left for the player to see
        xMin = 0;
        yMin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        moverXPos.x = moverXPos.x + speed;
        transform.position = moverXPos;

        Vector3 moverYPos = transform.position;
        moverYPos.y = moverYPos.y + speed;
        transform.position = moverYPos;

        //Screen.width;
        //gameCamera.WorldToScreenPoint(//somerandomvector);

        //set xMax to wherever is too far to the right for the player to see
        Vector3 screenTransformPosition = gameCamera.WorldToScreenPoint(transform.position);
        xMax = Screen.width;
        yMax = Screen.height;
        //set xMin to wherever is too far to the left for the player to see
        xMin = -9;
        yMin = -4.45f;

        if (xMax < screenTransformPosition.x)
        {
            speed *= -1;
        }

        if (xMin > screenTransformPosition.x)
        {
            speed *= -1;
        }

        if (yMax < screenTransformPosition.y)
        {
            speed *= -1;
        }

        if (yMin > screenTransformPosition.y)
        {
            speed *= -1;
        }
    }
}
