using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimmyMover : MonoBehaviour {

    [SerializeField]
    private float mSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }
    //when player is inside trigger timmy is walked by parent object
    private void OnTriggerStay(Collider other)
    {
        transform.Translate(Vector3.right * Time.deltaTime * mSpeed);
    }
}
