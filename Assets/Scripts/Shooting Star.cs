using UnityEditor;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float progress = 0;
    public Vector3 finalLocation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

     }

    // Update is called once per frame
    void Update()
    {
    //To get the shooting star to my final location I need to be able to assign a starting point, an ending point, and how fast the object is between those two points.
    //By creating a starting and ending variable, I can assign empty objects with pre-assigned positions to those values.
    //In this case it is the progress which determines how fast the object is moving between the two points.
    progress += Time.deltaTime / 4f;
    finalLocation = Vector3.Lerp(start.position, end.position, progress);
    transform.position = finalLocation;
}
}
