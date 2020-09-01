using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour
{
    public Transform target; //can create a tracking object in the inspector
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.position - offset;
    }
}
