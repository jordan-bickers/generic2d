using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamage : MonoBehaviour
{

    public int damage;
    public PlayerHealth playerHealth;

//lets us access PlayerMovement Script for KB stuff
    public PlayerMovement playerMovement;

    private void OnCollisionEnter2D(Collision2D collision)
    {
      //check if it was the player who collided
      if(collision.gameObject.tag == "Player")
      {
        //knockback effect
        playerMovement.KBCounter = playerMovement.KBTotalTime;
        //check direction of hit
        if(collision.transform.position.x <= transform.position.x)
        {
          playerMovement.KnockFromRight = true;
        }
        if(collision.transform.position.x > transform.position.x)
        {
          playerMovement.KnockFromRight = false;
        }

        //tells script to look in the playerHealth script, then TakeDamage function
        playerHealth.TakeDamage(damage);
      }
    }
}
