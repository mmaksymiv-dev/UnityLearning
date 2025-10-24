using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    //Move using RigidBody
    Rigidbody _rb;
    float _intupHorizontal;
    float _moveSpeed = 10f;
    Vector2 _currentVelocity;

    // Move using transform 
    float _moveTransform = 10f;


    // Trigger exemple
    bool _canInteract = false;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_canInteract)
                Debug.Log("Turn on ligth swich!");
        }
    }

    private void FixedUpdate()
    {
        MovePlayerRigidBody();
    }

    void MovePlayerRigidBody()
    {
        if(_intupHorizontal != 0)
        {
            _rb.linearVelocity = _currentVelocity;
        }
        else
        {
            _currentVelocity = new Vector2(0f, 0f);
            _rb.linearVelocity = _currentVelocity;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            Debug.Log("Enter");

            _canInteract = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            Debug.Log("Exit");

            _canInteract = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("Enter");
            collision.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }

        //if (collision.gameObject.name == "Sphere")
        //{
        //    Debug.Log("Enter");
        //}
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("Exit");
            collision.gameObject.GetComponent<MeshRenderer>().enabled = true;
        }

        //if (collision.gameObject.name == "Sphere")
        //{
        //    Debug.Log("Exit");
        //}
    }
}
