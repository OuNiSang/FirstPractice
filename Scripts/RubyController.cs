using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 PlayerPosition;
    void Start()
    {
        // Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //practice for keyborad controll

        float getUser_H_Input = Input.GetAxis("Horizontal"); //get the input from keyborad "a", "d", negitive = left, positive = right
        float getUser_V_Input = Input.GetAxis("Vertical");
        float getUser_3d_Input = Input.GetAxis("Mouse ScrollWheel");
        float test_input_Zoom = Input.GetAxis("Zoom joysticks");
        float test_input_move = Input.GetAxis("Move joysticks");
        float test_input_lockback = Input.GetAxis("lockback_rightstick");
        
        Debug.Log(test_input_lockback);
        Debug.Log(test_input_move);
        Debug.Log(test_input_Zoom);
        // Debug.Log(getUser_H_Input);
        // Debug.Log(getUser_V_Input);   //for monitoring
        // Debug.Log(getUser_3d_Input);
        Vector2 userPosision = transform.position;
        userPosision.x += 3f*getUser_H_Input*Time.deltaTime;//Time.deltatime means change from fram per fresh to time per fresh
        userPosision.y += 3f*getUser_V_Input*Time.deltaTime;
        transform.position = userPosision;

        PlayerPosition = userPosision;


        //practice for moving charactor

        // Vector2 posision = transform.position;
        // Quaternion rotation = transform.rotation;

        // posision.x = posision.x + 0.1f;
        // rotation.x = rotation.z + 10f;

        // transform.position = posision;
        // transform.rotation = rotation;

    }

    public Vector2 getPostion(){
        return PlayerPosition;
    }

}
