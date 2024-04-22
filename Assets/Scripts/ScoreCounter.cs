using System;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int _score;
    [SerializeField] TextMeshProUGUI _scoreText;

    void Start()
    {
        _score = 0;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        _scoreText.text = $"Score: {_score}";
    }

    public void AddScore(int points)
    {
        _score += points;
        UpdateScoreText();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Transform>())
        {
            AddScore(1);
        }
    }
}