using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMover : MonoBehaviour {

    public Rigidbody rb;

    [SerializeField]
    int speed = 10;
    [SerializeField]
    int brakeSpeed = 10;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	
	void FixedUpdate () {
        //'vertical movement' and 'velocity' variables.
        float verM = Input.GetAxis("Vertical");
        var vel = rb.velocity;

        if (verM > 0) {
            Vector3 movement = new Vector3(0, 0, 1);
            rb.AddForce(movement * speed);
        }

        //Braking only works when there is foreward movement.
        if (verM < 0 && vel.z > 0 ) {
            Vector3 movement = new Vector3(0, 0, 1);
            rb.AddForce(-movement * brakeSpeed);
        }

        //No driving backwards shenanigans.
        
        if (vel.z < 0.000) {
            Vector3 movement = Vector3.zero;
            rb.velocity = movement;
        }
        
        //Debug.Log(vel.z);
    }
}
