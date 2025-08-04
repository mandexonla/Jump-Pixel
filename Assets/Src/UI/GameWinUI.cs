using UnityEngine;
using UnityEngine.UI;

public class GameWinUI : MonoBehaviour
{
    [SerializeField] private GameObject gameWinScreen;
    [SerializeField] private Button playAgainButton;
    public static bool isGameWon;

    private void Awake()
    {
        isGameWon = false;

        playAgainButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.GameScene);
        });
    }

    void Update()
    {
        if (isGameWon)
        {
            gameWinScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
