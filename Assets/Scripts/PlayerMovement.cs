using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
  public bool jumpTrigger;

  public Rigidbody2D playerRb;
  public float speed;

  //tracks x (left or right)
  public float input;

  //grabs sprite image
  public SpriteRenderer spriteRenderer;
  public float jumpForce;

  //player size
  public float playerSize = 5f;

//ground layer check
  public LayerMask groundLayer;
  private bool isGrounded;

  public LayerMask platform;
  private bool isPlatformed;


  //feet pos check
  public Transform feetPosition;
  public float groundCheckCircle;

  //checks how long you are in the air, max = jumpTime
  public float jumpTime = 0.35f;
  public float jumpTimeCounter;

  //jumps
  public int maxJumps;
  public int jumpCounter;

  //check if jump has already been initiated to prevent double jump
  private bool isJumping;

//set knockback force
  public float KBForce;
  //watches how long the knockback effect has been played
  public float KBCounter;
  public float KBTotalTime;
//direction of knockback
  public bool KnockFromRight;


    // Update is called once per frame
    void Update()
    {
      //sets -1 or 1 depending on key press
       input = Input.GetAxisRaw("Horizontal");
       //flips image direction based on this value
        if(input < 0)
        {
          transform.localScale = new Vector3(-playerSize, playerSize, 1);
          // spriteRenderer.flipX = true;
        }
        else if(input > 0)
        {
           transform.localScale = new Vector3(playerSize, playerSize, 1);
          // spriteRenderer.flipX = false;
        }

      //Check if grounded
      isGrounded = Physics2D.OverlapCircle(feetPosition.position, groundCheckCircle, groundLayer);
      
      if(isGrounded)
      {
        jumpCounter = (maxJumps - 1);
      }

      if(isGrounded == true && Input.GetKeyDown(KeyCode.UpArrow))
      {
        
        isJumping = true;
        jumpTimeCounter = jumpTime;
        playerRb.velocity = Vector2.up * jumpForce;
      }

      if (Input.GetKey(KeyCode.UpArrow) && isJumping == true)
      {
        if(jumpTimeCounter > 0)
        {
          playerRb.velocity = Vector2.up * jumpForce;
          jumpTimeCounter -= Time.deltaTime;
        }
        else
        {
          isJumping = false;
        }

      }

      if(Input.GetKeyUp(KeyCode.UpArrow))
      {
        isJumping = false;
      }



    //check if platformed
      isPlatformed = Physics2D.OverlapCircle(feetPosition.position, groundCheckCircle, platform);

        if(isPlatformed)
      {
        jumpCounter = (maxJumps - 1);
      }

    if(isPlatformed == true && Input.GetKeyDown(KeyCode.UpArrow))
      {
        isJumping = true;
        jumpTimeCounter = jumpTime;
        playerRb.velocity = Vector2.up * jumpForce;
      }

      if (Input.GetKey(KeyCode.UpArrow) && isJumping == true)
      {
        if(jumpTimeCounter > 0)
        {
          playerRb.velocity = Vector2.up * jumpForce;
          jumpTimeCounter -= Time.deltaTime;
        }

      }

      if(Input.GetKeyUp(KeyCode.UpArrow))
      {
        isJumping = false;
      }


      if(jumpTrigger && jumpCounter > 0 && Input.GetKeyDown(KeyCode.UpArrow))
      {
        
          jumpCounter -= 1;
          isJumping = true;
          jumpTimeCounter = jumpTime;
          playerRb.velocity = Vector2.up * jumpForce;
        
      }


    }

  void FixedUpdate()
  {
    if(KBCounter <= 0)
    {
      playerRb.velocity = new Vector2 (input * speed, playerRb.velocity.y);
    }
    else
    {
      if(KnockFromRight == true)
      {
        //Sets player to move left and up (-)
        playerRb.velocity = new Vector2(-KBForce, KBForce);
      }
      if(KnockFromRight == false)
      {
        //sets player to move right and up (+)
        playerRb.velocity = new Vector2(KBForce, KBForce);
      }

      KBCounter -= Time.deltaTime;

    }
    
  }

 
}
