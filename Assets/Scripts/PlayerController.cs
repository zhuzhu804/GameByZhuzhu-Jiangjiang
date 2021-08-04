using UnityEngine;

/*
 * Behaviour to handle keyboard input and also store the player's
 * current health.
 */
public class PlayerController : MonoBehaviour
{
  private Rigidbody2D rigidbody2d;
  private int health;
  private bool canJump;

  /*
   * Apply initial health and also store the Rigidbody2D reference for
   * future because GetComponent<T> is relatively expensive.
   */
  private void Start()
  {
    health = 6;
    rigidbody2d = GetComponent<Rigidbody2D>();
  }

  /*
   * Remove one health unit from player and if health becomes 0, change
   * scene to the end game scene.
   */
  public void Damage()
  {
    health -= 1;

    if(health < 1)
    {
      Application.LoadLevel("EndGame");
    }
  }

  /*
   * Accessor for health variable, used by he HUD to display health.
   */
  public int GetHealth()
  {
    return health;
  }

  /*
   * Poll keyboard for when the up arrow is pressed. If the player can jump
   * (is on the ground) then add force to the cached Rigidbody2D component.
   * Finally unset the canJump flag so the player has to wait to land before
   * another jump can be triggered.
   */
  private void Update()
  {
    if(Input.GetKeyDown(KeyCode.UpArrow))
    {
      if(canJump == true)
      {
        rigidbody2d.AddForce(new Vector2(0, 500));
        canJump = false;
      }
    }
  }

  /*
   * If the player has collided with the ground, set the canJump flag so that
   * the player can trigger another jump.
   */
  private void OnCollisionEnter2D(Collision2D other)
  {
    canJump = true;
  }
}
