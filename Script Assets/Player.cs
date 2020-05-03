using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField]
    // public static int health = 100;

    [System.Serializable]
    public class PlayerStats
    {
        public int health = 100;
    }

    public Animator animator;

    public PlayerStats playerStats = new PlayerStats();

    public int fallBoundry = -20;

    void Update()
    {
        //TODO move this to payermovement
        //animator.setFloat("yPos", transform.position.y);

        //if the player falls off the platform
        if (transform.position.y <= fallBoundry)
        {
            GameMaster.KillPlayer(this);
        }
    }

    public void DamagePlayer(int damage)
    {
        playerStats.health -= damage;
        if (playerStats.health <= 0)
        {
            GameMaster.KillPlayer(this);
        }
    }

    //public void Death()
    // {
    //    GameMaster.KillPlayer(this);
    //}

    public void setLocation(float x, float y, float z){
        transform.position = new Vector3(x, y, z);
    }

}
