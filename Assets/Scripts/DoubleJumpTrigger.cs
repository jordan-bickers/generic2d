using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpTrigger : MonoBehaviour
{
  public bool DoubleJump;
    public PlayerMovement playerMovement;

  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.CompareTag("Double Jump Trigger"))
    {
      DoubleJump = true;
      if(DoubleJump == true)
      {
        playerMovement.jumpTrigger = true;
      }
      
      // playerMovement.playerSize = 1f;
    }
  }
}
