using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class Fields : MonoBehaviour
{
    //Fields
    [SerializeField] private int _playerHealthSerializeField = 100; // [SerializeField] allows this value to be set in the Unity Inspector without making it public.
    private int _playerHealth = 100;
    private float _playerSpeed = 4.6f;
    private bool _isGrounded = true;
    private string _playerName = "test";
    //private Vector3 _playerPosition = new Vector3(5f, 5f, 5f);
    private Vector2 _playerPosition = new Vector2(5f, 5f);

    private Rigidbody _rg;

    private void Start()
    {
        //gameObject.transform.position = _playerPosition;

        _rg = gameObject.GetComponent<Rigidbody>();
        _rg.mass = 0.05f;
    }
}