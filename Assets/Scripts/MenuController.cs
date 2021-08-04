using UnityEngine;

/*
 * Small behaviour to handle menu button callbacks.
 */
public class MenuController : MonoBehaviour
{
  /*
   * When the start button is pressed, load the Game scene.
   */
  public void OnStartClicked()
  {
    Application.LoadLevel("Game");
  }

  /*
   * When the back button is clicked, load the Menu scene.
   */
  public void OnBackClicked()
  {
    Application.LoadLevel("Menu");
  }
}
