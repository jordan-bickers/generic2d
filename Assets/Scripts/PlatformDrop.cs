using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDrop : MonoBehaviour
{

  public LayerMask platform;
  private bool isPlatformed;

  //feet pos check
  public Transform feetPosition;
  public float groundCheckCircle;

    // Update is called once per frame
    void Update()
    {

       //check if platformed
      isPlatformed = Physics2D.OverlapCircle(feetPosition.position, groundCheckCircle, platform);

        if(isPlatformed == true && Input.GetKeyDown(KeyCode.DownArrow))
        {
          StartCoroutine(FallTimer());
        }
    }

  //allows effect to happen for a period of time
  //yield creates a wait
  //turns off then on collider
  IEnumerator FallTimer()
  {
    GetComponent<CapsuleCollider2D>().enabled = false;
    yield return new WaitForSeconds (0.15f);
    GetComponent<CapsuleCollider2D>().enabled = true;
  }


}
