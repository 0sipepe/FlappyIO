using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreUI;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private TextMeshProUGUI bestScoreUI;

    int score;
    public static int bestScore;
    private static int generalScore = 0;

    public void UpdateScore(int addScore)
    {
        score += addScore;
        scoreUI.text = score.ToString();
    }
    public void GameOver()
    {
        if (score >= bestScore)
        {
            bestScore = score;
        }
        generalScore += score;
        bestScoreUI.text = "Best score = " + bestScore.ToString();
        deathScreen.SetActive(true);
    }
}
