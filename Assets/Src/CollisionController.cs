using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Trap"))
        {
            GameOverUI.isGameOver = true;
        }
        else if (collision.gameObject.CompareTag("Cup"))
        {
            GameWinUI.isGameWon = true;
        }
    }

}
