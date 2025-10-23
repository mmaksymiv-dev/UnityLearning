using UnityEngine;

public class EnableDisable1 : MonoBehaviour
{
    [SerializeField] GameObject _cubeParent;
    [SerializeField] GameObject _cube;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _cubeParent.SetActive(false);
            Debug.Log(_cubeParent.activeInHierarchy);
        }
    }
}
