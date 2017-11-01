using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{

    public AudioClip ButtonClick_Audio;
    public AudioClip ButtonHover_Audio;
    public Vector3 playersource;

    // Use this for initialization
    void Start()
    {
        playersource = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (gameObject.tag == "StartButton")
        {
            AudioSource.PlayClipAtPoint(ButtonClick_Audio, playersource, 3f); //sound effects for clicking while buttondown
            SceneManager.LoadScene("CarMovementTest"); //what function does after buttondown enabled by function above
        }

        if (gameObject.tag == "LevelSelectButton")
        {
            AudioSource.PlayClipAtPoint(ButtonClick_Audio, playersource, 3f);
            SceneManager.LoadScene("LevelSelect");
        }

        if (gameObject.tag == "ReturnButton")
        {
            AudioSource.PlayClipAtPoint(ButtonClick_Audio, playersource, 3f);
            SceneManager.LoadScene("MainMenu");
        }

        if (gameObject.tag == "ReplayButton")
        {
            AudioSource.PlayClipAtPoint(ButtonClick_Audio, playersource, 3f);
            SceneManager.LoadScene("Game");
        }

        if (gameObject.tag == "TutorialButton")
        {
            AudioSource.PlayClipAtPoint(ButtonClick_Audio, playersource, 3f);
            SceneManager.LoadScene("Tutorial");
        }

        if (gameObject.tag == "QuitButton")
        {
            AudioSource.PlayClipAtPoint(ButtonClick_Audio, playersource, 3f);
            Application.Quit();
            Debug.Log("Quit Works"); //used to check quite button works before build
        }
    }

    private void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white; //color changed to white
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red; //returns normal colors back from hover grey (curent buttons are multi color, but final version will have all red)
    }


}
