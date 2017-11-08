using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollosisionDestroy : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "KillBox")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Level 1");
        }
    }
}
