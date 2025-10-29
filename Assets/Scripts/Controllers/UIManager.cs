using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private GameObject panel;
    private SelectableObject _currentObject;

    private void Awake()
    {
        Instance = this;
        HideMenu();
    }

    public void ShowMenu(SelectableObject obj)
    {
        _currentObject = obj;
        panel.SetActive(true);
    }

    public void HideMenu()
    {
        panel.SetActive(false);
    }

    // --- Buttons ---
    public void OnAddShip() => ShipManager.Instance.AddShip(_currentObject);
    public void OnRemoveShip() => ShipManager.Instance.RemoveShip(_currentObject);
    public void OnSendShip() => ShipManager.Instance.SendShip(_currentObject);
}
