using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotateBy;
    //public GameObject gameObject;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = gameObject.GetComponent<Renderer>().bounds.center;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateBy, Space.Self);        
    }
}
