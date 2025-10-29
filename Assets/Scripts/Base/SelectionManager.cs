using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private Camera _camera;
    private SelectableObject _currentSelection;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            HandleClick();
    }
    private void HandleClick()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            var selectable = hit.collider.GetComponent<SelectableObject>();
            if (selectable != null)
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

        UIManager.Instance.ShowObjectMenu(_currentSelection);
    }

    private void Deselect()
    {
        if (_currentSelection == null)
            return;

        _currentSelection.OnDeselect();
        _currentSelection = null;
        UIManager.Instance.HideObjectMenu();
    }
}
