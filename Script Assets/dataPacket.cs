using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dataPacket : MonoBehaviour{

	private static float totalTime;
	
	
	public void setTotalTime(float t){
		totalTime = t;
	}
	
	public float getTotalTime(){
		return totalTime;
	}

}