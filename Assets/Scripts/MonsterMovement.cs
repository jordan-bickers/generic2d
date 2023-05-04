using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{

  //lets you set patrol points
  public Transform[] patrolPoints;
  public float moveSpeed;
  public int patrolDestination;



  // Update is called once per frame
  void Update()
  {
    if (patrolDestination == 0)
    {
      //current, destination, speed
      transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
      //execute when enemy gets close to point 0
      if (Vector2.Distance(transform.position, patrolPoints[0].position) < .2f)
      {
        transform.localScale = new Vector3(1, 1, 1);
        patrolDestination = 1;
      }
    }

    if (patrolDestination == 1)
    {
      //current, destination, speed
      transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
      //execute when enemy gets close to point 1
      if (Vector2.Distance(transform.position, patrolPoints[1].position) < .2f)
      {
        transform.localScale = new Vector3(-1, 1, 1);
        patrolDestination = 0;
      }
    }
  }
}
