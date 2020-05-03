using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	
	public Text timerText;
	private float startTime;
	private float timeLength;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //float
		timeLength = Time.time - startTime;
		
		string minutes = ((int) timeLength / 60).ToString();
		string seconds = (timeLength % 60).ToString("f2");

		timerText.text = minutes + ":" + seconds;
    }
	
	public float getTimeLength(){
		return timeLength;
	}
}
