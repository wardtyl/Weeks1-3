using UnityEngine;

public class TimerCounter : MonoBehaviour
{
    public Camera gameCamera;
    public float speed = 0.10f;
    public float waitDuration = 1.01f;
    public float reset;
    private float timePassed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > waitDuration)
        {
         //   float reset = 0f;

           // for (int speed = 0.10f; speed < 1.01; speed++)
            { }
            }
        }
    }

