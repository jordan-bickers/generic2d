using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamingoTrigger : MonoBehaviour
{
    public FlamingoBehaviour flamingoBehaviour;

  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.CompareTag("Flamingo Trigger"))
    {
      flamingoBehaviour.deathByFlamingo = true;

    }
    else
    {
      flamingoBehaviour.deathByFlamingo = false;
    }
  }
}
