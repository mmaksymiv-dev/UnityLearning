using System;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    //Move using RigidBody
    Rigidbody _rb;
    float _intupHorizontal;
    float _moveSpeed = 60f;

    public bool _disableMovement = false;

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
    }

    private void FixedUpdate()
    {
        if (!_disableMovement)
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        if(_intupHorizontal != 0)
        {
            _rb.AddRelativeForce(new Vector3(_intupHorizontal * _moveSpeed, 0f));
        }
    }
}
