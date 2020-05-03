using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Fire : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rigidbody2d;
	public GameObject player;

    public float moveSpeed = 0.0000000000000001f;

    void OnTriggerEnter2D(Collider2D Fire)
    {
        if (Fire.CompareTag("Player"))
        {
			Timer rt = player.GetComponent<Timer>();
			//dataPacket dataHolder = new dataPacket();
			//dataHolder.setTotalTime(rt.getTimeLength());
			//Debug.Log("The Time is :"+rt.getTimeLength());
			//Debug.Log(dataHolder.getTotalTime());
			
			//Debug.Log("The Time is :"+rt.getTimeLength());
			//Debug.Log(dataHolder.getTotalTime());
			
			string minutes = ((int) rt.getTimeLength() / 60).ToString();
			string seconds = (rt.getTimeLength() % 60).ToString("f2");

			string str = minutes + ":" + seconds;
			
			StreamWriter writer = new StreamWriter("data.txt", true);
			//System.IO.File.WriteAllText("data.txt", string.Empty);
			writer.WriteLine(str);
			writer.Close();
			
			//Debug.Log("Test");
            SceneManager.LoadScene(3);
        }
    }

    // Update is called once per frame
    void Update()
    {
		transform.position = new Vector3(transform.position.x, player.transform.position.y, 0);
        transform.Translate(moveSpeed  * Time.deltaTime * 0.12f, 0, 0);
    }
}


//using static Player;
//using static PlayerMovement;

//public class Fire : MonoBehaviour
//{
//    public static Player player;
//    public static PlayerMovement playerMovement;

//    Rigidbody2D rigidbody2d;

// Start is called before the first frame update
//    void Start()
//    {
//       player = GameObject.FindObjectOfType<Player>();
//        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
//       //player = GetComponent<Player>();
//        //playerMovement = GetComponent<PlayerMovement>();
//    }

// Update is called once per frame
//    void Update()
//   {
//        if (playerMovement.activityCheck() == true)
//        {
//            rigidbody2d.velocity = new Vector2(1, rigidbody2d.velocity.y);
//        }
//    }

//    void onPlayerContact(Collider2D hitbox)
//    {
//       if (hitbox.gameObject.name = "Fire")
//        {
//           player.Death;
//       }
//   }

//    public void OnCollisionEnter2D (Collision2D collision)
//    {
//        player = collision.collider.GetComponent<player>();
//        if (player != null)
//        {
//            player.Death();
//       }
//    }
//}
