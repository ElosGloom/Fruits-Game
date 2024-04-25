using System;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI currentScoreText;

    private void Awake()
    {
        
        ScoreHandler.OnCurrentScoreChangeEvent += UpdateScoreText;
    }

   private void UpdateScoreText(int score)
   {
       currentScoreText.text = $"Score: {score}";
        // ScoreHandler.UpdateScore(score);
    }


   private void OnDestroy()
   {
       ScoreHandler.OnCurrentScoreChangeEvent -= UpdateScoreText;
   }
}