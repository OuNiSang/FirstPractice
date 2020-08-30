using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posision = transform.position;
        Quaternion rotation = transform.rotation;

        posision.x = posision.x + 0.1f;
        rotation.x = rotation.z + 10f;

        transform.position = posision; 
        transform.rotation = rotation;
    
    }
}
