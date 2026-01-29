using UnityEngine;

public class Star : MonoBehaviour
{
    public float duration;
    public float size;
    private float progress = 0f;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime / duration;
        size = curve.Evaluate(progress);

        transform.localScale = Vector3.one * size;

        if (progress > 1f)
        {
            progress = 0f;
        }
    }
}

