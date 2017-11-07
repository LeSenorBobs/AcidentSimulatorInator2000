using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerAreaChecker : MonoBehaviour {

    float mSpeed = 3;

	// Use this for initialization
	void Start () {
	
	}

    private void Update()
    {
        
    }
    //when player collides with box, player dies
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Destroy(other.gameObject);
            Debug.Log("PleaseDie");
        }
        Debug.Log("does it even work?");
    }
}

