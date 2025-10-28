using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float moveSpeed = 10f;
    private float sprintMultiplier = 2f;
    private float rotationSpeed = 100f;
    private float zoomSpeed = 50f;
    private float minHeight = -20f;
    private float maxHeight = 30f;
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
        _currentSpeed = moveSpeed * (isSprinting ? sprintMultiplier : 1f);

        Vector3 move = new Vector3(hor, 0f, ver);
        transform.Translate(move * _currentSpeed * Time.deltaTime, Space.Self);
    }

    private void HandleRotation()
    {
        float rotate = 0f;
        if (Input.GetKey(KeyCode.Q)) rotate -= 1f;
        if (Input.GetKey(KeyCode.E)) rotate += 1f;

        transform.Rotate(Vector3.up, rotate * rotationSpeed * Time.deltaTime, Space.World);
    }

    private void HandleZoom()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (Mathf.Abs(scroll) > 0.001f)
        {
            transform.position += transform.up * scroll * zoomSpeed * Time.deltaTime;
        }
    }

    private void ClampHeight()
    {
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, minHeight, maxHeight);
        transform.position = pos;
    }
}