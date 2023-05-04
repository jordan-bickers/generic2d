using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite oldSprite;

    public int maxHealth = 10;
    public int health;

  //disable player on death / link scripts
  public SpriteRenderer playerSr;
  public PlayerMovement playerMovement;


  //link to LivesManager
  // public LivesManager livesManager;

  // Start is called before the first frame update
  void Start()
  {
    health = maxHealth;
  }


  //takes damage value from enemy script and adds to player health
  public void TakeDamage(int damage)
  {

    // StartCoroutine(ChangeSprite());
    // livesManager.LoseLife();
    health -= damage;
    if (health <= 0)
    {
      //movement enabled false
      //sr enabled false
      playerSr.enabled = true;
      playerMovement.enabled = true;
    }
  }


  // IEnumerator ChangeSprite()
  // {
  //   playerMovement.playerSize = 0.15f;
  //   spriteRenderer.sprite = newSprite;
  //   yield return new WaitForSeconds(1);
  //   spriteRenderer.sprite = oldSprite;
  //   playerMovement.playerSize = 5f;
  // }

}
