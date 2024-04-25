using UnityEngine;

public class FruitIdentifier: MonoBehaviour
{
    
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
           var fruit =  other.gameObject.GetComponent<Fruit>();
           
          ScoreHandler.AddScore(fruit.FruitValue);
        }
    }
} 