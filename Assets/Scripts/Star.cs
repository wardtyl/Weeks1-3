using UnityEngine;

public class Star : MonoBehaviour
{
    public float size;
    public float period;
    public float progress = 0f;
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Progress indicates the progress along the animation curve (similar to a percentage value/bar).
        //Period represents how long I want the animation curve to take over a period of time.
        //I have used the values within my animation curve to determine the size of the object. The size/scale is determined by progress resetting between 1f and 0f.
        progress += Time.deltaTime / period;
        size = curve.Evaluate(progress);
        transform.localScale = Vector3.one * size;

        if (progress > 1f)
        {
            progress = 0f;
        }
    }
}

