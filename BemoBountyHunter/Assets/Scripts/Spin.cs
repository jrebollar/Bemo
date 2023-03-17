using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    float originalY;
    public float floatStrength = 1;

    void Start()
    {
        this.originalY = this.transform.position.y;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,
        originalY + ((float)Mathf.Sin(Time.time) * floatStrength),
        transform.position.z);
        transform.Rotate(new Vector3(0f, 5f, 0f) * Time.deltaTime);
    }
}
