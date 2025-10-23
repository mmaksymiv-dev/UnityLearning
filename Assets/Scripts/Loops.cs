using UnityEngine;

public class Loops : MonoBehaviour
{
    [SerializeField] GameObject _item;
    void Start()
    {
        // while
        int itemCount = 2;

        while (itemCount > 0)
        {
            SpawnItem();
            itemCount--;
        }

        // do while
        itemCount = 3;

        do
        {
            SpawnItem();
            itemCount--;
        }
        while (itemCount > 0);

        // for
        for (int i = 5; i > 0; i--)
        {
            SpawnItem();
        }
    }

    void SpawnItem()
    {
        Instantiate(_item, new Vector2(Random.Range(6.5f, -6.5f), Random.Range(3.5f, -3.5f)), Quaternion.identity);
    }
}
