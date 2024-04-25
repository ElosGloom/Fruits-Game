using UnityEngine;

public class FruitReturner : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        var go = other.gameObject;
        if (go.CompareTag("Fruit"))
        {
            other.rigidbody.velocity = new Vector3();
            FPS.Pool.FluffyPool.Return(go.GetComponent<Transform>());
        }
    }
}