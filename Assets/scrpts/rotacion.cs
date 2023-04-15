using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour
{

    public float rostx = 0.0f, rosty = 0.0f, rostz = 0.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(rostx, rosty, rostz) * Time.deltaTime);
    }
}
