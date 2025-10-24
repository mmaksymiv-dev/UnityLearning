using System.Collections;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    [SerializeField] GameObject _teleportLocation;
    PlayerController3 _playerController;

    Coroutine _coroutine;

    private void Start()
    {
        _playerController = GetComponent<PlayerController3>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //StartCoroutine(TeleportDelay());

            _coroutine = StartCoroutine(TeleportDelay());
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //StopAllCoroutines();

            StopCoroutine(_coroutine); // or StopCoroutine(TeleportDelay());
        }
    }

    IEnumerator TeleportDelay()
    {
        _playerController._disableMovement = true;
        yield return new WaitForSeconds(3);
        gameObject.transform.position = _teleportLocation.transform.position;
        yield return new WaitForSeconds(3);
        _playerController._disableMovement = false;
    }
}