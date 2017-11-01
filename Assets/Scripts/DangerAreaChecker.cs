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
        transform.Translate(Vector3.forward * Time.deltaTime * mSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Debug.Log("Failed");
    }
}

