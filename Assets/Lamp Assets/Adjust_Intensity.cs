using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adjust_Intensity : MonoBehaviour
{

    Light lt;

    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            lt.intensity += .01f;
        if (Input.GetMouseButton(1))
            lt.intensity -= .01f;
    }
}
