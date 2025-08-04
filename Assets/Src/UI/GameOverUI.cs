using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public static GameOverUI instance;
    public static bool isGameOver;
    [SerializeField] private GameObject gameOverScreen;

    private void Awake()
    {
        isGameOver = false;
    }

    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
