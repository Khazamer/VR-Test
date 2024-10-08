using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 3f;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "PlayerBullet") {
            Destroy(other.gameObject);
            health = health - 1f;
            if(health == 0) {
                Destroy(gameObject);
            }
        }
        else if (other.gameObject.tag == "Lightsaber") {
            Destroy(gameObject);
        }
    }
}
