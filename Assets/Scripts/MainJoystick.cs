using UnityEngine;

[RequireComponent(typeof(Joystick))]
public class MainJoystick : MonoBehaviour
{
    public static MainJoystick Instance { get; private set; }
    [SerializeField] private Joystick joystick;


    public bool IsActive()
    {
        const float joystickThreshold = 0.15f;
        return joystick.Direction.magnitude > joystickThreshold && isActiveAndEnabled;
    }

    public Vector3 Direction => joystick.Direction;

    public void Awake()
    {
        Instance = this;
    }
}