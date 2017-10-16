using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMover : MonoBehaviour {

    public Rigidbody rb;

    [SerializeField]
    int speed = 10;
    [SerializeField]
    int tiltSpeed = 10;
    [SerializeField]
    int turnSmoothing = 10;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

	}
	
	
	void FixedUpdate () {
        //Testing movement
        if (Input.GetAxis("Vertical") != 0)
        {
            Vector3 movement = new Vector3(1, 0, 0 );
            rb.AddForce(movement * speed);
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            float horizontalTilt = Input.GetAxis("Horizontal") * tiltSpeed;
            Quaternion turn = Quaternion.Euler(0, horizontalTilt, 0);
            transform.rotation = turn;
        }
    }
}
