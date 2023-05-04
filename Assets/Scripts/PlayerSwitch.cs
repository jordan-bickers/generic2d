using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{

  public PlayerMovement playerMovement;
  public FlamingoMovement player2Movement;
  public bool player1Active = true;


    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.RightShift))
      {
        SwitchPlayer();
      }   
    }


    public void SwitchPlayer()
    {
      if(player1Active == true)
      {
        playerMovement.enabled = false;
        player2Movement.enabled = true;
        player1Active = false;
      }
      else
      {
        playerMovement.enabled = true;
        player2Movement.enabled = false;
        player1Active = true;
      }
    }
}
