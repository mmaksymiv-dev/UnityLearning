using UnityEngine;

public class TranslateRotateLookat : MonoBehaviour
{
    float _moveSpeed = 10f;
    float _rotateSpeed = 200f;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(new Vector3(0f, _moveSpeed, 0f) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(new Vector3(0f, -_moveSpeed, 0f) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(new Vector3(-_rotateSpeed, 0f, 0f) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(new Vector3(_rotateSpeed, 0f, 0f) * Time.deltaTime, Space.Self);
        }
    }
}
