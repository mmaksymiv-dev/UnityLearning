using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    List<string> _names = new List<string>();
    private void Start()
    {
        _names.Add("Test1");
        _names.Add("Test2");

        _names.Remove("Test1");
        _names.Insert(1, "Test3");

        Debug.Log(_names[1]);
    }

    private void Update()
    {

    }
}
