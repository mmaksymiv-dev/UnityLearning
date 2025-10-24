using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // Example 01
    int _number = 12;
    int[] _numberArray = new int[4];

    // Example 02
    string[] _name = { "test1", "test2", "test3" };

    // Exaple 03
    [SerializeField] GameObject[] _players;

    void Start()
    {
        _numberArray[0] = 10;
        _numberArray[1] = 23;
        _numberArray[2] = 53;
        _numberArray[3] = 15;

        Debug.Log(_numberArray[0]);

        _players = GameObject.FindGameObjectsWithTag("Player");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _players = GameObject.FindGameObjectsWithTag("Player");
        }
    }
}
