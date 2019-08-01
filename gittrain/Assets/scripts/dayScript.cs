using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayScript : MonoBehaviour
{
    public float speed = 0;
    void Start()
    {
       
    }

    
    void Update()
    {
        gameObject.transform.Rotate(speed, 0, 0);
    }
}
