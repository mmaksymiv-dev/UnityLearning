using System;
using UnityEngine;

public class Properties : MonoBehaviour
{
    private int _playerHealth = 100;

    public int PlayerHealth
    {
        get
        {
            return _playerHealth;
        }
        set
        {
            _playerHealth = value;
        }
    }

    public string DisplayHealthPercentage
    {
        get
        {
            return _playerHealth.ToString() + "%";
        }
    }

    public int PlayerHealth1 { get; set; }

    private void Start()
    {
        Debug.Log(DisplayHealthPercentage);
    }
}
