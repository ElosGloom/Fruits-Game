using UnityEngine;

public class Fruit : MonoBehaviour
{
    // [SerializeField] private string fruitType;
    [SerializeField] private int fruitValue;

    // public string FruitType => fruitType;

    public int FruitValue => fruitValue;
}