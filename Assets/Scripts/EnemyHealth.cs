using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 3f;
    //public NextLevel nextlevelscript;

    private void start() {
        //nextlevelscript = FindObjectOfType<NextLevel>();
    }
    private void OnCollisionEnter(Collision other)
    {   
        /*
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0,0,0);
        Rigidbody rb2 = other.gameObject.GetComponent<Rigidbody>();
        rb2.velocity = new Vector3(0,0,0);
        */
        //rb.angularVelocity = new Vector3(0,0,0);
        if (other.gameObject.tag == "PlayerBullet") {
            Destroy(other.gameObject);
            health = health - 1f;
            if(health == 0) {
                //nextlevelscript.enemyDead();
                Destroy(gameObject);
            }
        }
        else if (other.gameObject.tag == "Lightsaber") {
            //nextlevelscript.enemyDead();
            Destroy(gameObject);
        }
    }
}
