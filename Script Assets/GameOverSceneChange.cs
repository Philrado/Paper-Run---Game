using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSceneChange : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D water)
    {
        if (water.CompareTag("Player"))
        {
			//Debug.Log("Test");
            SceneManager.LoadScene(3);
        }
    }
}
