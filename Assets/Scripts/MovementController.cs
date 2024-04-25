using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;

    private void FixedUpdate()
    {
        var isJoystickActive = MainJoystick.Instance.IsActive();
        if (isJoystickActive)
            rb.velocity = MainJoystick.Instance.Direction * speed;
        else
        {
            rb.velocity = new Vector3();
        }
    }
}