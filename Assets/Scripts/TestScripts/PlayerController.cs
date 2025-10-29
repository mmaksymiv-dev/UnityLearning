using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Move using RigidBody
    Rigidbody _rb;
    float _intupHorizontal;
    float _moveSpeed = 10f;
    Vector2 _currentVelocity;

    // Move using transform 
    float _moveTransform = 10f;

    void Start()
    {
        //Move using RigidBody
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move using RigidBody
        _intupHorizontal = Input.GetAxisRaw("Horizontal");
        _currentVelocity = new Vector2(_intupHorizontal * _moveSpeed, 0f);

        //MovePlayerTransform();
    }

    private void FixedUpdate()
    {
        MovePlayerRigidBody();
    }

    void MovePlayerTransform()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-_moveTransform * Time.deltaTime, 0f), Space.Self);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(_moveTransform * Time.deltaTime, 0f), Space.Self);
        }
    }

    void MovePlayerRigidBody()
    {
        if(_intupHorizontal != 0)
        {
            _rb.angularVelocity = _currentVelocity;
        }
        else
        {
            _currentVelocity = new Vector2(0f, 0f);
            _rb.angularVelocity = _currentVelocity;
        }
    }
}
