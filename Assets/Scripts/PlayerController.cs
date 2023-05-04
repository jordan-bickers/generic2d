using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;

    public float moveSpeed;
    public float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;
    // public int maxJumps = 3;
    // public int _jumpsLeft;




    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();

        // moveSpeed = 2f;
        // jumpForce = 30f;
        // isJumping = false;
        // _jumpsLeft = maxJumps;
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        if (moveHorizontal > 0.1f)
        {
            rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
            transform.localScale = new Vector2(1f, 1.5f);
        }
        else if (moveHorizontal < -0.1f)
        {
            rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
            transform.localScale = new Vector2(-1f, 1.5f);
        }

        if (!isJumping && moveVertical > 0.1f)
        {
            rb2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
            // _jumpsLeft -= 1;
        }
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
      if (collision.gameObject.tag == "Platform") 
      {
          isJumping = false;
      }
    }

    void OnTriggerExit2D(Collider2D collision) 
    {
      if (collision.gameObject.tag == "Platform") 
      {
          isJumping = true;
      }
    }
}
