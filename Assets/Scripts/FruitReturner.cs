using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Transform>())
        {
            FPS.Pool.FluffyPool.Return(other.gameObject.GetComponent<Transform>());
        }
    }
}
