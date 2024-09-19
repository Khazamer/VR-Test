using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    public GameObject rightHand;

    Quaternion currentRotation;
    Quaternion targetRotation;

    Quaternion newRotation;

    // Start is called before the first frame update
    void Start()
    {   
        currentRotation = gameObject.transform.rotation;
        targetRotation = GameObject.Find("RightHand Controller").transform.rotation;

        newRotation = currentRotation * targetRotation;

        gameObject.transform.rotation = newRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
