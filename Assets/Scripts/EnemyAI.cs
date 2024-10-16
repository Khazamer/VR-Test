using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //[SerializeField]
    private float speed = 3f; //10 - SET IN UNITY

    private GameObject playerTarget;

        // When the player enters the trigger, assign it as a target
    private void OnTriggerEnter(Collider other) {
        playerTarget = other.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // Only move forward if there is a player target
        if (playerTarget != null) {
            //GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            transform.LookAt(playerTarget.transform.position);
            transform.position += transform.forward * Time.deltaTime * speed; //issue with collision but idk why
            /*
            if (addSpeed == true) {
                transform.position += transform.forward * Time.deltaTime * speed;
                addSpeed = false;
            }
            */
        }
    }
}