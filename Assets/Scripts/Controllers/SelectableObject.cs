using UnityEngine;

public class SelectableObject : MonoBehaviour
{
    [SerializeField] private string locationName;
    [SerializeField] private Material highlightMaterial;

    private Material _defaultMaterial;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        if (_renderer != null)
            _defaultMaterial = _renderer.material;
    }

    public string LocationName => locationName;

    public void OnSelect()
    {
        if (_renderer != null && highlightMaterial != null)
            _renderer.material = highlightMaterial;
    }

    public void OnDeselect()
    {
        if (_renderer != null && _defaultMaterial != null)
            _renderer.material = _defaultMaterial;
    }
}
