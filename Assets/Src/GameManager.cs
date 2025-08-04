using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;
        GameOverUI.instance.gameOverScreen.SetActive(false);
    }
}
