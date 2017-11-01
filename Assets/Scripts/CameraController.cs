using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]
    Rigidbody rb = new Rigidbody();

    [SerializeField]
    Quaternion Turningangle = new Quaternion(0,0,0,0);

    // Use this for initialization
    void Start () {
        transform.rotation = Turningangle;
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Turningangle;
    }
}
