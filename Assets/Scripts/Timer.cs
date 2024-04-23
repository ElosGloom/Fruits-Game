using Game.Scripts.GUI;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float targetTime;

    private void Update()
    {
        float t = targetTime -= Time.deltaTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("00");

        timerText.text = minutes + ":" + seconds;

        if (targetTime <= 0.0f)
        {
            TimerEnded();
        }
    }

    private void TimerEnded()
    {
        Time.timeScale = 0;
    }
}