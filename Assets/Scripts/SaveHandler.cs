using UnityEngine;

public class SaveHandler:MonoBehaviour
{
    public static void SavePrefs()
    {
        // PlayerPrefs.SetInt("BestScore", _bestScore);
        // PlayerPrefs.SetInt("LastScore", _lastScore);
        PlayerPrefs.Save();
    }
 
    public static void LoadPrefs()
    {
        // int volume = PlayerPrefs.GetInt("Volume", 0); 
    }
}