using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorAngle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float angle = Random.Range(-45, 45f);
        transform.Rotate(Vector3.forward, angle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
