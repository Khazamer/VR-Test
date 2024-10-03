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
        //shotTime -= 0.05f;

        if (shotTime <= 0.0f) {
            transform.LookAt(playerTarget.transform);
            GameObject newBullet = Instantiate(BulletTemplate, transform.position + (transform.forward  * 0.7f), transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower * (1/Time.deltaTime));
            Destroy(newBullet, 5);

            shotTime = rnd.Next(2,5);

            GetComponent<AudioSource>().PlayOneShot(gunShotSFX);
        }
    }
}