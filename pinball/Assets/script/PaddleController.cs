using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode input;

    float targetPressed;
    float targetRelease;

    HingeJoint hinge;
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
        // MovePaddle();
    }
    
    void ReadInput()
    {
        JointSpring jointspring = hinge.spring;
        if(Input.GetKey(input)){
            jointspring.targetPosition = targetPressed;
        }else{
            jointspring.targetPosition = targetRelease;
        }

        hinge.spring = jointspring;
    }
    // void MovePaddle()
    // {

    // }
}
