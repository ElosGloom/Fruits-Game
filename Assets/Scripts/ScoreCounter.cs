using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int _score;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        _score = 0;
        UpdateScoreText();
    }

   private void UpdateScoreText()
    {
        scoreText.text = $"Score: {_score}";
    }

    public void AddScore(int points)
    {
        _score += points;
        UpdateScoreText();
    }

    
}