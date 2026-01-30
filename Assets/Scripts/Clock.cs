using UnityEngine;

public class Clock : MonoBehaviour
{
    public float rotationSpeed;
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles -= transform.forward * rotationSpeed * Time.deltaTime;
    }
}
