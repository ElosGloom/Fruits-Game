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

        float randomRotationX = Random.Range(0, 360);
        float randomY = Random.Range(0, 360);
        float randomZ = Random.Range(0, 360);

        Quaternion randomRotation = Quaternion.Euler(randomRotationX, randomY, randomZ);

        var fruit = FluffyPool.Get<Transform>(new RandomFruit().GetRandomFruitKey());
        fruit.transform.position = randomPosition;
        fruit.transform.rotation = randomRotation;
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.gray;
        Gizmos.DrawWireSphere(transform.position, spawnRange);
    }
}