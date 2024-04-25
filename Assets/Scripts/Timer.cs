using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float targetTime;
    [SerializeField] private ScoreWindow scoreWindow;

    private float _currentTime;
    private float _cashedTime;

    private void Start()
    {
        _cashedTime = targetTime;
    }

    private void Update()
    {
        _currentTime = targetTime -= Time.deltaTime;

        string minutes = ((int)_currentTime / 60).ToString();
        string seconds = (_currentTime % 60).ToString("00");

        timerText.text = minutes + ":" + seconds;

        if (targetTime <= 0.0f)
        {
            Time.timeScale = 0;
            TimerEnded();
        }
    }

    private void TimerEnded()
    {
        scoreWindow.gameObject.SetActive(true);
        ScoreHandler.UpdateScore();
        ScoreHandler.SetBestScore();
        scoreWindow.SetScore();
        SaveHandler.SavePrefs();
    }

    public void RestartTimer()
    {
        Time.timeScale = 1;
        targetTime = _cashedTime;
        scoreWindow.gameObject.SetActive(false);
        ScoreHandler.ResetScore();
    }
}