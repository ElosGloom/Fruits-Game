using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private Camera _mainCamera;
    private bool _mouseDown;
    private Vector3 _cashedPosition;
    [SerializeField] private float startXRange;
    [SerializeField] private float endXRange;

    private void Awake()
    {
        _cashedPosition = transform.position;
        _mainCamera = Camera.main;
    }

    private void OnMouseDown()
    {
        _mouseDown = true;
    }

    private void OnMouseUp()
    {
        _mouseDown = false;
    }

    private void Update()
    {
        if (_mouseDown )
        {
            Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

            var position = transform.position;
            float posZ = position.z;
            float posY = position.y;
            Vector3 newPos = ray.origin + ray.direction;
            newPos.z = posZ;
            newPos.y = posY;
            newPos.x = Mathf.Clamp(newPos.x, startXRange, endXRange);
            _cashedPosition = position;

            position = newPos;
            transform.position = position;
        }
        else
        {
            transform.position = _cashedPosition;
        }
    }
}