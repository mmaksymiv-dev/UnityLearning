using UnityEngine;
using System.Collections.Generic;

public class ShipManager : MonoBehaviour
{
    public static ShipManager Instance { get; private set; }
    [SerializeField] private GameObject shipPrefab;

    private List<GameObject> _ships = new();

    private void Awake()
    {
        Instance = this;
    }

    public void AddShip(SelectableObject location)
    {
        var ship = Instantiate(shipPrefab, location.transform.position + Vector3.up * 1.5f, Quaternion.identity);
        _ships.Add(ship);
    }

    public void RemoveShip(SelectableObject location)
    {
        var ship = _ships.Find(s => Vector3.Distance(s.transform.position, location.transform.position) < 2f);
        if (ship != null)
        {
            _ships.Remove(ship);
            Destroy(ship);
        }
    }

    public void SendShip(SelectableObject target)
    {
        if (_ships.Count == 0) return;
        var ship = _ships[0];
        ship.GetComponent<Ship>().MoveTo(target.transform.position);
    }
}
