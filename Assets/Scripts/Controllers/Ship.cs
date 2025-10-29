using UnityEngine;

public class Ship : MonoBehaviour
{
    private Vector3 _target;
    private bool _isMoving;
    private float _speed = 5f;

    public void MoveTo(Vector3 target)
    {
        _target = target;
        _isMoving = true;
    }

    private void Update()
    {
        if (!_isMoving) return;

        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, _target) < 0.1f)
        {
            _isMoving = false;
            Debug.Log("Ship arrived at destination");
        }
    }
}
