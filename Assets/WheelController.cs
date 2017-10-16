using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour {

    [SerializeField]
    [Range(0,500)]
    float speed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            HingeJoint joint = GetComponent<HingeJoint>();
            if (joint != null)
            {
                joint.useMotor = true;
                JointMotor motor = joint.motor;
                motor.force = 50.0f * speed;
                motor.targetVelocity = 100f * speed;
                joint.motor = motor;

                if (Input.GetButtonDown("Fire1"))
                {
                    speed = 50.0f;
                }

                if (Input.GetButtonUp("Fire1"))
                {
                    speed = 1.0f;
                }
            }
        }

        else
        {
            HingeJoint joint = GetComponent<HingeJoint>();
            if (joint != null)
            {
                joint.useMotor = true;
                JointMotor motor = joint.motor;
                motor.force = 0f;
                motor.targetVelocity = 100f;
                joint.motor = motor;
            }
        }
	}

}
