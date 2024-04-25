using System;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public static event Action<int> OnCurrentScoreChangeEvent;
    private static int _bestScore;
    private static int _lastScore;
    private static int _currentScore;

    public static int BestScore => _bestScore;
    public static int LastScore => _lastScore;


    private void Start()
    {
        _bestScore = _lastScore;
        _currentScore = 0;
        OnCurrentScoreChangeEvent?.Invoke(_currentScore);
        
    }

    public static void UpdateScore()
    {
        _lastScore = _currentScore;
    }

    public static void SetBestScore()
    {
        if (_lastScore >= _bestScore)
        {
            _bestScore = _lastScore;
        }
    }

    public static void ResetScore()
    {
        _currentScore = 0;
        OnCurrentScoreChangeEvent?.Invoke(_currentScore);
    }

    public static void AddScore(int points)
    {
        _currentScore += points;
        OnCurrentScoreChangeEvent?.Invoke(_currentScore);
    }
}