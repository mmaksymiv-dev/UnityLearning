using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    BoxCollider _col;

    void Start()
    {
        _col = gameObject.GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _col.enabled = !_col.enabled;
        }
    }
}
