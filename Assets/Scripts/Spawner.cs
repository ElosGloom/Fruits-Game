using System;
using FPS.Pool;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private float spawnRange;
    [SerializeField] private float spawnHeight;
    


    private void Start()
    {
        InvokeRepeating(nameof(RandomPlaceSpawner), 0f, 0.5f);
    }

    private void RandomPlaceSpawner()
    {
        Vector2 centerPosition = transform.position;

        float randomX = Random.Range(centerPosition.x - spawnRange, centerPosition.x + spawnRange);
        Vector2 randomPosition = new Vector2(randomX, spawnHeight);
        
        float randomRotatationX = Random.Range(0, 360);
        float randomY = Random.Range(0, 360);
        float randomZ = Random.Range(0, 360);

        Quaternion randomRotation = Quaternion.Euler(randomRotatationX, randomY, randomZ);

        var fruit = FluffyPool.Get<Transform>(GetRandomFruitKey());
        fruit.transform.position = randomPosition;
        fruit.transform.rotation = randomRotation;
    }

    private string GetRandomFruitKey()
    {
        var values = Enum.GetValues(typeof(Fruits));
        var random = Random.Range(0, values.Length);

        Fruits randomFruit = (Fruits)values.GetValue(random);
        string fruitKey = randomFruit.ToString();

        return fruitKey;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.gray;
        Gizmos.DrawWireSphere(transform.position, spawnRange);
    }
}