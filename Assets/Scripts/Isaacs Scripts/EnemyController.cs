using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Vector3 startingPosition;
    
    public float speed;
    public float amplitude;
    public float amplitudeOffset;
    
    public Transform pointA;
    public Transform pointB;
    
    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(pointA.position, pointB.position, Mathf.Sin(Time.time * speed) * amplitude + amplitudeOffset);
    }
}
