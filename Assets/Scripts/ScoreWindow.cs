using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWindow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lastSore;
    [SerializeField] private TextMeshProUGUI bestSore;
    [SerializeField] private Button playButton;
    [SerializeField] private Timer timer;

    private void Start()
    {
        playButton.onClick.AddListener(RestartLevel);
    }

    public void SetScore()
    {
        lastSore.text = $"Last Score {ScoreHandler.LastScore}";
        bestSore.text = $"Best Score {ScoreHandler.BestScore}";
    }

    private void RestartLevel()
    {
        timer.RestartTimer();
    }

}