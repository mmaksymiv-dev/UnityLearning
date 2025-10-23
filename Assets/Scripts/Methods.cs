using UnityEngine;

public class Methods : MonoBehaviour
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

    private void Start()
    {
        TakeDamage(50);
        Debug.Log(PlayerHealth);
    }

    void TakeDamage(int damage)
    {
        PlayerHealth -= damage;
    }
}
