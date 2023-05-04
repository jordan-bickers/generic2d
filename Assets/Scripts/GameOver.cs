using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
  //starts false
  // private bool isGameOver;
  public bool displayGameOver;
  //grabs pausePanel
  public GameObject gameOverPanel;

  //link to playerhealth
  public PlayerHealth playerHealth;

  public PlayerMovement playerMovement;


  // Update is called once per frame
  void Update()
  {
    //if player health is less than 0 gameover is true
    if(playerHealth.health <= 0)
    {
      SetGameOver();
    }
  }



  public void SetGameOver()
  {
    // Time.timeScale = 0;
    //turn off render and movement
    // playerMovement.enabled = false;
    // playerMovement.speed = 0f;
    gameOverPanel.SetActive(true);
  }

}
