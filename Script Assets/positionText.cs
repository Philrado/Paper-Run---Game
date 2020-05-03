using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionText : MonoBehaviour
{
    public GameObject player;
    public Camera camera;
    private Vector3 playerPos;
    private RectTransform rt;
    private RectTransform canvasRT;
    private Vector3 playerScreenPos;
	
	void Start(){
		playerPos = player.transform.position;
		
		rt = GetComponent<RectTransform>();
        canvasRT = GetComponentInParent<Canvas>().GetComponent<RectTransform>();
        playerScreenPos = camera.WorldToViewportPoint(player.transform.TransformPoint(playerPos));
        rt.anchoredPosition = camera.transform.position;
		//player.transform.position;
		//playerScreenPos;//+new Vector3(0,45,0);
		//rt.anchorMax = playerScreenPos;
        //rt.anchorMin = playerScreenPos;
	}
	
	// Update is called once per frame
    void Update () {
        playerScreenPos = camera.WorldToViewportPoint(player.transform.TransformPoint(playerPos));
		rt.anchoredPosition = camera.transform.position;//player.transform.position;//playerScreenPos;
        //rt.anchorMax = playerScreenPos;
        //rt.anchorMin = playerScreenPos;
    }
	
	public void setLocation(float x, float y, float z){
        transform.position = new Vector3(x, y, z);
    }
}