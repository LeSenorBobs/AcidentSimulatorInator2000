using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMover : MonoBehaviour {

    public Rigidbody rb;

    [SerializeField]
    int speed = 10;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

	}
	
	
	void FixedUpdate () {
        //Testing movement
        if (Input.GetAxis("Vertical") != 0)
        {
            Vector3 movement = new Vector3(speed, 0, 0 );
            rb.velocity = movement;
        }
    }
}
