using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;

public class Reflect2Script : MonoBehaviour
{
    private float reflectSpeedModifier = 3f; //move in same direction as saber
    private bool collided = false;

    // 180 code
    void OnCollisionEnter(Collision collision) {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.transform.LookAt(gameObject.transform);
        rb.transform.rotation = Quaternion.Inverse(rb.transform.rotation);
        rb.AddForce(transform.forward * 5 * (1/Time.deltaTime));
    }
}