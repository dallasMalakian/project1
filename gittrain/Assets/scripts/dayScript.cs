using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayScript : MonoBehaviour
{
    public Vector3 speed;
    void Start()
    {
       
    }

    
    void Update()
    {
        gameObject.transform.Rotate(speed);
    }
}
