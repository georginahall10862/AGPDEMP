using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Countdown : MonoBehaviour {

    public Text timerText;
    public float startTime = 120f;
    public float t;


    // Use this for initialization
    void OnEnable () {
        t = startTime;// - Time.time;
    
    }

	void OnDisable () {

		timerText.text = "";
	}

    // Update is called once per frame
    void Update () {
        t -= Time.deltaTime;
        string minutes = ((int)t / 60).ToString ();
        string seconds = (t % 60).ToString ("f2");
    
        timerText.text = "Time: " +  minutes + ":" + seconds;
        if (t <= 0)
        { //Time = 0 game over
            t = 0;
			enabled = false;
        }
}
}