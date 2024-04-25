using UnityEngine;

public class AppInitializer : MonoBehaviour
{
    [SerializeField] private GameObject game;
    
    private async void Awake()
    {
         await FPS.Pool.FluffyPool.InitAsync();
         StartGame();
    }

    private void StartGame()
    {
        game.SetActive(true);
    }
}