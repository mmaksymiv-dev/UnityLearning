using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float _moveSpeed = 10f;
    private float _sprintMultiplier = 2f;
    private float _rotationSpeed = 100f;
    private float _zoomSpeed = 50f;
    private float _minHeight = -20f;
    private float _maxHeight = 30f;
    private float _currentSpeed;

    private void Update()
    {
        HandleMovement();
        HandleRotation();
        HandleZoom();
        ClampHeight();
    }

    private void HandleMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        bool isSprinting = Input.GetKey(KeyCode.LeftShift);
        _currentSpeed = _moveSpeed * (isSprinting ? _sprintMultiplier : 1f);

        Vector3 move = new Vector3(hor, 0f, ver);
        transform.Translate(move * _currentSpeed * Time.deltaTime, Space.Self);
    }

    private void HandleRotation()
    {
        float rotate = 0f;
        if (Input.GetKey(KeyCode.Q)) rotate -= 1f;
        if (Input.GetKey(KeyCode.E)) rotate += 1f;

        transform.Rotate(Vector3.up, rotate * _rotationSpeed * Time.deltaTime, Space.World);
    }

    private void HandleZoom()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (Mathf.Abs(scroll) > 0.001f)
        {
            transform.position += transform.up * scroll * _zoomSpeed * Time.deltaTime;
        }
    }

    private void ClampHeight()
    {
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, _minHeight, _maxHeight);
        transform.position = pos;
    }
}