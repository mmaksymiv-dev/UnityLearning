using UnityEngine;

public class TranslateRotateLookat2 : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector2 lastRotation;

    void Update()
    {
        //gameObject.transform.LookAt(target);

        Vector2 direcrion = target.position - transform.position;

        if (lastRotation != direcrion)
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.up, direcrion);
        }

        lastRotation = direcrion;
    }
}
