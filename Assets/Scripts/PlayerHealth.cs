using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 10;
    public int health;

//disable player on death / link scripts
    public SpriteRenderer playerSr;
    public PlayerMovement playerMovement;


    //link to LivesManager
    // public LivesManager livesManager;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }


//takes damage value from enemy script and adds to player health
  public void TakeDamage(int damage)
  {
    // livesManager.LoseLife();
    health -= damage;
    if(health <= 0)
    {
      playerSr.enabled = false;
      playerMovement.enabled = false;
    }
  }

}
