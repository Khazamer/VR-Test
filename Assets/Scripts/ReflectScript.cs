using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;

public class ReflectScript : MonoBehaviour
{
    private float reflectSpeedModifier = 20f; //move in same direction as saber
    private bool collided = false;
    // need to test code
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Lightsaber") {
            if(!collided) {
                collided = true;
                // 180 code
                //Rigidbody rb = GetComponent<Rigidbody>();
                //rb.velocity = -rb.velocity;
                // direction of saber code
                Rigidbody rb = GetComponent<Rigidbody>();
                Quaternion saberDirection = collision.gameObject.transform.rotation;
                //Quaternion ballDirection = Quaternion.Inverse(saberDirection);
                //rb.transform.rotation = ballDirection;
                rb.transform.rotation = saberDirection;
                rb.AddForce(transform.forward * reflectSpeedModifier * (1/Time.deltaTime));
                //rb.AddForce(transform.forward * reflectSpeedModifier);

                gameObject.tag = "PlayerBullet";
            }
        }
    }
}
