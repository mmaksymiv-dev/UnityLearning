using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private GameObject objectMenu;
    [SerializeField] private Text objectNameText;

    private void Awake()
    {
        Instance = this;
        HideObjectMenu();
    }

    public void ShowObjectMenu(SelectableObject selected)
    {
        objectMenu.SetActive(true);
        objectNameText.text = selected.ObjectName;
    }

    public void HideObjectMenu()
    {
        objectMenu.SetActive(false);
    }
}
