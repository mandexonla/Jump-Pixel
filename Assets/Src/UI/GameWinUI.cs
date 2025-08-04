using UnityEngine;

public class GameWinUI : MonoBehaviour
{
    [SerializeField] private GameObject gameWinScreen;
    public static bool isGameWon;

    private void Awake()
    {
        isGameWon = false;
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
