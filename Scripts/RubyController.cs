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
        posision.x = posision.x + 0.1f;
        transform.position = posision; 
    
    }
}
