using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    private float gameTimer = 0.0f;

    public Text timerText;

    //timer on top left screen to show time in game (while alive)
    // Update is called once per frame
    void Update()
    {
        gameTimer += Time.deltaTime;
        timerText.text = ((int)gameTimer).ToString();
    }
}
