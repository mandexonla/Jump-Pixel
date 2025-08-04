using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public static GameOverUI instance;
    public static bool isGameOver;
    [SerializeField] public GameObject gameOverScreen;
    [SerializeField] private Button playAgainButton;

    private void Awake()
    {
        isGameOver = false;

        playAgainButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.GameScene);
        });

        instance = this;
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
