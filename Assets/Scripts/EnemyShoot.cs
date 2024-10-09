using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.WebSockets;
//using System.Random;
using UnityEngine.Audio;

public class EnemyShoot : MonoBehaviour
{
    public GameObject BulletTemplate;
    public GameObject playerTarget;
    float shootPower = 5f;
    float shotTime;
    System.Random rnd = new System.Random();

    [SerializeField]
    private LayerMask teleportMask;
    public AudioClip gunShotSFX;

    // Start is called before the first frame update
    void Start()
    {
        shotTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        shotTime -= Time.deltaTime;

        if (shotTime <= 0.0f) {
            transform.LookAt(playerTarget.transform);

            bool didHit = checkRaycast();

            //hits = Physics.RaycastAll(transform.position, transform.forward, distance);

            //bool goodShot = true;

            //if (Physics.Raycast(transform.position, transform.forward, out hit, teleportMask)) {
            if (!didHit) { //see if plant is cuasing issue - otherwise ask peter
                //Debug.DrawRay(transform.position, transform.forward, Color.green, 3, false); //Stops the shooting for some reason
                //print("Found object" + hit.collider.tag + " and " + hit.distance);
                //if (hit.collider.tag == "ShotCheck") {
                GameObject newBullet = Instantiate(BulletTemplate, transform.position + (transform.forward  * 0.7f), transform.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower * (1/Time.deltaTime));
                Destroy(newBullet, 5);

                //shotTime = rnd.Next(2,5);
                //shotTime = 2f;
                GetComponent<AudioSource>().PlayOneShot(gunShotSFX);

                //Debug.Log("Enemy shooting");
                //}
            }

            shotTime = rnd.Next(2,5);
        }
    }

    bool checkRaycast() {
        //transform.LookAt(playerTarget.transform);

        RaycastHit hit;

        float distance = Vector3.Distance(gameObject.transform.position, playerTarget.transform.position);

        bool didHit = Physics.Raycast(
            transform.position,
            transform.forward,
            out hit,
            distance,
            teleportMask);

        //GameObject collidedObject = object.GetObjectFromInstanceID(hit.colliderInstanceID);

        // Debugging - not needed atm
        /*
        Debug.Log("Clear");
        Debug.Log("Hit: " + didHit + " What: " + hit.collider);
        //Debug.DrawRay(transform.position, transform.forward, Color.green, 3, false);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, transform.forward);
        */

        return didHit;
    }
}