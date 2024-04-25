using System;
using Random = UnityEngine.Random;

public class RandomFruit
{
    public string GetRandomFruitKey()
    {
        var values = Enum.GetValues(typeof(Fruits));
        var random = Random.Range(0, values.Length);

        Fruits randomFruit = (Fruits)values.GetValue(random);
        string fruitKey = randomFruit.ToString();

        return fruitKey;
    }
}