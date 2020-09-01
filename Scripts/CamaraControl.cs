using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour
{
    public RubyController target;
    private Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        // offset = target.getPostion();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.getPostion();
    }
}
