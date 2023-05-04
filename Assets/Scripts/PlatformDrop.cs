using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
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
