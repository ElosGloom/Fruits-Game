using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] private int reward;

    public int Reward => reward;
}