using UnityEngine;

public class FruitCollector : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            var fruit = other.gameObject.GetComponent<Fruit>();

            ScoreHandler.AddScore(fruit.Reward);
        }
    }
}