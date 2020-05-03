using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class EndSceneChange : MonoBehaviour{
	
	public GameObject importantinfo;
	
	
    void OnTriggerEnter2D(Collider2D water){
        if(water.CompareTag("Player")){
			Timer rt = importantinfo.GetComponent<Timer>();
			//dataPacket dataHolder = new dataPacket();
			//dataHolder.setTotalTime(rt.getTimeLength());
			//Debug.Log("The Time is :"+rt.getTimeLength());
			//Debug.Log(dataHolder.getTotalTime());
			
			string minutes = ((int) rt.getTimeLength() / 60).ToString();
			string seconds = (rt.getTimeLength() % 60).ToString("f2");

			string str = minutes + ":" + seconds;
			
			StreamWriter writer = new StreamWriter("data.txt", true);
			//File.WriteAllText("data.txt", "");
			writer.WriteLine(str);
			writer.Close();
            //PlayerPrefs.SetFloat("CurrentTime", rt.getTimeLength());
			SceneManager.LoadScene(2);
        }
    }
}