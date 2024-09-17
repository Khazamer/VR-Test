using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private float health = 3f;
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        health = health - 1f;
        if(health == 0) {
            Destroy(gameObject);
        }
    }
}
