using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RayCast : MonoBehaviour
{
    [SerializeField]
    private GameObject playerOrigin;
    [SerializeField]
    private LayerMask teleportMask;
    [SerializeField]
    private InputActionReference teleportButtonPress;

    // Start is called before the first frame update
    void Start()
    {
        teleportButtonPress.action.performed += DoRaycast;
    }

    void DoRaycast(InputAction.CallbackContext __) {
        RaycastHit hit;

        bool didHit = Physics.Raycast(
            transform.position,
            transform.forward,
            out hit,
            Mathf.Infinity,
            teleportMask);

        if (didHit) {
            playerOrigin.transform.position = hit.collider.gameObject.transform.position;
        }
        /*
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, teleportMask)) {
            Debug.Log(hit.collider.gameObject.name);
        }
        */
    }
}
