using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;

public class ReflectScript : MonoBehaviour
{
    private float reflectSpeedModifier = 20f; //move in same direction as saber
    private bool collided = false;
    /*
    private void OnCollisionEnter(Collision collsion)
    {
        if (collsion.gameObject.tag == "PlayerBullet") {
			Rigidbody rb = collsion.gameObject.GetComponent<Rigidbody>();
            Vector3 currentVel = rb.velocity;

            //ContactPoint contactPoint = other.contacts[0];
            ContactPoint contactPoint = collsion.contacts[0];
            Vector3 normal = contactPoint.normal;
            // Vector3 reflectedVel = Vector3.Reflect(currentVel * reflectSpeedModifier, normal);
            Vector3 reflectedVel = Vector3.Reflect(collsion.gameObject.transform.position, gameObject.);
            rb.velocity = contactPoint.normal * -1 * reflectSpeedModifier;
		}
    }
    */
    /*
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "PlayerBullet") {
            other.gameObject.transform.rotation = gameObject.transform.rotation;
        }
    }
    */
    /*
    void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
            // Visualize the contact point
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
    }
    */
    //Main code that is having issues
    /*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Lightsaber" && collided == false) {
            // assuming this script is in the object you want to bounce
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 currentVel = rb.velocity;
            // there could be multiple contact points but i'm just gonna take the first one
            ContactPoint contactPoint = collision.contacts[0];
            Vector3 normal = contactPoint.normal;
            Vector3 reflectedVel = Vector3.Reflect(currentVel, normal);
            rb.velocity = reflectedVel;
            collided = true;
        }
    }
    */
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

                gameObject.tag = "PlayerBullet";
            }
        }
    }
}
