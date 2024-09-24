using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f; //10

    private GameObject playerTarget;

    // Update is called once per frame
    void Update()
    {
        // Only move forward if there is a player target
        if (playerTarget != null) {
            transform.LookAt(playerTarget.transform.position);
            transform.position += transform.forward * Time.deltaTime * speed;
        }
    }

    // When the player enters the trigger, assign it as a target
    private void OnTriggerEnter(Collider other) {
        playerTarget = other.gameObject;
    }
}
