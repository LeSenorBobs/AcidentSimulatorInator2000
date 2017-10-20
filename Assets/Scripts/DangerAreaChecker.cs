using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerAreaChecker : MonoBehaviour {

    //entertime,
    float eTime;

	// Use this for initialization
	void Start () {
		
	}
	
    void OnTriggerEnter(Collider other)
    {
        eTime = Time.fixedTime;
        Debug.Log(eTime);
    }

    private void OnTriggerStay(Collider other)
    {
        eTime = Time.fixedTime;
        Debug.Log(eTime);
    }


    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        Debug.Log("Failed");
    }


}

