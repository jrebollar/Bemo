using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision collision)
    {
        Debug.Log("something happened");
        GameObject obj = collision.gameObject;
        if(obj.tag == "Fish")
        {
            Debug.Log("it hit");
        }
    }
}
