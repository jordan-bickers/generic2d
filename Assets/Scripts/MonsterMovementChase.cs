using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovementChase : MonoBehaviour
{

//lets you set patrol points
  public Transform[] patrolPoints;
  public float moveSpeed;
  public int patrolDestination;

//tracks player pos
  public Transform playerTransform;
  public bool isChasing;

  //how far can enemy see
  public float chaseDistance;


    // Update is called once per frame
    void Update()
    {

      if (isChasing) 
      {
        //if player is left of enemy
        if(transform.position.x > playerTransform.position.x) 
        {
          //enemy will move left
          transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        //uf player is right of enemy
        if(transform.position.x < playerTransform.position.x) 
        {
          //enemy will move right
          transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
      }
      else
      {

        if(patrolDestination == 0)
        {
          //current, destination, speed
          transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
          //execute when enemy gets close to point 0
          if(Vector2.Distance(transform.position, patrolPoints[0].position) < .2f)
          {
            transform.localScale = new Vector3(1, 1, 1);
            patrolDestination = 1;
          }
        }

        if(patrolDestination == 1)
        {
          //current, destination, speed
          transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
          //execute when enemy gets close to point 1
          if(Vector2.Distance(transform.position, patrolPoints[1].position) < .2f)
          {
            transform.localScale = new Vector3(-1, 1, 1);
            patrolDestination = 0;
          }
        }
      }
    //checks this object pos and player pos to see if its within chase distance
        if(Vector2.Distance(transform.position, playerTransform.position) < chaseDistance)
        {
          isChasing = true;
        }
        else
        {
          isChasing = false;
        }

        
    }
}
