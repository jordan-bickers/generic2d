using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamingoBehaviour : MonoBehaviour
{
  public Rigidbody2D flamingoRb;
  public bool deathByFlamingo;
  public GameObject Flamingo;

  public float x;
  public float y;

    void Start()
    {
      flamingoRb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(deathByFlamingo)
        {
          flamingoRb.gravityScale = 10;
        }
        else
        {
          Flamingo.transform.position = new Vector2(y, x);
          flamingoRb.gravityScale = 0;
        }
        
            
         
          
        
    }

}
