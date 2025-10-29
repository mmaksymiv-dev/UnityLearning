using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private Camera _camera;
    private SelectableObject _currentSelection;

    private void Awake()
    {
        _camera = Camera.allCameras[0];
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            TrySelect();
    }

    private void TrySelect()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            
            if (hit.collider.TryGetComponent<SelectableObject>(out var selectable))
                Select(selectable);
            else
                Deselect();
        }
    }

    private void Select(SelectableObject selectable)
    {
        if (_currentSelection == selectable)
            return;

        _currentSelection?.OnDeselect();
        _currentSelection = selectable;
        _currentSelection.OnSelect();

        UIManager.Instance.ShowMenu(_currentSelection);
    }

    private void Deselect()
    {
        if (_currentSelection == null)
            return;

        _currentSelection.OnDeselect();
        _currentSelection = null;
        UIManager.Instance.HideMenu();
    }
}
