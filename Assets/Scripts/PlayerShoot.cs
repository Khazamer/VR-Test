using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

public class PlayerShoot : MonoBehaviour
{
    public GameObject BulletTemplate;
    float shootPower = 20f;

    float tempTime;

    public InputActionReference trigger;

    public AudioClip gunShotSFX;

    // Start is called before the first frame update
    void Start()
    {
        trigger.action.performed += Shoot;
    }

    // Update is called once per frame
    void Shoot(InputAction.CallbackContext _)
    {
        //Remeber this and see if it works
        //tempTime = Time.timeScale;
        //Time.timeScale = 1F;
        GameObject newBullet = Instantiate(BulletTemplate, transform.position + (transform.forward * 0.7f), transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower * (1/Time.deltaTime)); //(1/Time.timeScale)
        //Time.timeScale = tempTime;

        Destroy(newBullet, 5);

        GetComponent<AudioSource>().PlayOneShot(gunShotSFX);
    }
}