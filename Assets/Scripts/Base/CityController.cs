using UnityEngine;

public class CityController : MonoBehaviour
{

    private void OnSelect()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("click");
        }
    }

}
