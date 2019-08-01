using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamp : MonoBehaviour
{
    bool power = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(power == true)
            {
                GetComponent<Light>().intensity = 0;
            }
            else
            {
                GetComponent<Light>().intensity = 4;
            }
            power = !power;
        }
    }
}
