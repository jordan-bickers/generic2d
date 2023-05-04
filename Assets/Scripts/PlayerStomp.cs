using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStomp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.CompareTag("Weak Point"))
      {
        Destroy(other.transform.parent.gameObject);
      }
    }

    
}
