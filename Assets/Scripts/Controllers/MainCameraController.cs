using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    //Movement Settings
    [SerializeField] private float moveSpeed = 20f;
    [SerializeField] private float rotationSpeed = 100f;
    [SerializeField] private float zoomSpeed = 100f;

    //Zoom Limits
    [SerializeField] private float minHeight = 10f;
    [SerializeField] private float maxHeight = 50f;

    //Map Bounds
    private Vector2 xLimits = new Vector2(-50, 50);
    private Vector2 zLimits = new Vector2(-50, 50);

    private void Update()
    {
        HandleMovement();
        HandleRotation();
        HandleZoom();
        ClampPosition();
    }

    private void HandleMovement()
    {
        float hor = Input.GetAxis(Const.Horizontal);
        float ver = Input.GetAxis(Const.Vertical);

        Vector3 move = new Vector3(hor, 0f, ver);
        transform.Translate(move * moveSpeed * Time.deltaTime, Space.Self);
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
        float scroll = Input.GetAxis(Const.MouseScrollWheel);
        transform.position += transform.up * scroll * zoomSpeed * Time.deltaTime;
    }

    private void ClampPosition()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, xLimits.x, xLimits.y);
        pos.z = Mathf.Clamp(pos.z, zLimits.x, zLimits.y);
        pos.y = Mathf.Clamp(pos.y, minHeight, maxHeight);
        transform.position = pos;
    }
}
