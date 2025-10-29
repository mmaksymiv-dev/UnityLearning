using UnityEngine;

public class SelectableObject : MonoBehaviour
{
    [SerializeField] private string objectName;

    public string ObjectName => objectName;

    public void OnSelect()
    {
        Debug.Log($"Selected: {objectName}");
    }

    public void OnDeselect()
    {

    }
}
