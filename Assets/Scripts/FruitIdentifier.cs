using UnityEngine;

public class FruitIdentifier: MonoBehaviour
{
    [SerializeField] private ScoreCounter score;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
           var fruit =  other.gameObject.GetComponent<Fruit>();
           
           score.AddScore(fruit.FruitValue);
        }
    }
} 