using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public bool reverseSlide;
    
    public float speed;  
    public float amplitude;
    public float amplitudeOffset;
    
    public Transform PointA;
    public Transform PointB;
            
    void Start()
    {
        Debug.Log(transform.position);
        if(reverseSlide)
        {
            PointA.position = new Vector3(-PointA.position.x, PointA.position.y, PointA.position.z);
            PointB.position = new Vector3(-PointB.position.x, PointA.position.y, PointA.position.z);
        }
    }
    
    // Update is called once per frame
    void Update()
    {                   
        
        transform.position = Vector3.Lerp(PointA.position, PointB.position, Mathf.Sin(Time.time * speed) * amplitude + amplitudeOffset);
        Debug.Log(transform.position);
    }
}

