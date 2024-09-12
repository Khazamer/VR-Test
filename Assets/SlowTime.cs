using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    //public InputActionReference trigger;

    //public Time.timeScale = 0.5;

    public GameObject leftHand;
    public GameObject rightHand;

    //public lastPosition;

    //Need to init - somehow set vector to 0
    public Vector3 prevLeft;
    public Vector3 prevRight;
    public Vector3 posLeft;
    public Vector3 posRight;

    float minSpeed = 0.05f;

    public float factor = 200f;

    float distance;

    float scaledDistance;

    float timeCheck;

    //public float maxDistance = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        //trigger.action.performed
        prevLeft = leftHand.transform.position;
        prevRight = rightHand.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Time.timeScale = 0.5f; // <- This will make the game move at half speed

        //public prev = Vector3.leftHand.transform.position;

        //2 Hands
        
        posLeft = leftHand.transform.position;
        posRight = rightHand.transform.position;

        if(Vector3.Distance(prevLeft,posLeft) > Vector3.Distance(prevRight,posRight))
        {
            distance = Vector3.Distance(prevLeft,posLeft);
        }
        else
        {
            distance = Vector3.Distance(prevRight,posRight);
        }

        //distance = Vector3.Distance(pos, prev);

        scaledDistance = distance * factor;

        timeCheck = math.max(scaledDistance,minSpeed);
        
        Time.timeScale = math.min(timeCheck,1);
        
        // 1 hand
        /*
        distance = Vector3.Distance(posLeft, prevLeft);

        scaledDistance = distance * factor;

        timeCheck = math.max(scaledDistance,minSpeed);
        
        Time.timeScale = math.min(timeCheck,1);
        */
        //maxDistance = math.max(distance,maxDistance);

        //timeCheck = distance/maxDistance;

        //Time.timeScale = math.max(distance/maxDistance,minSpeed);

        // Divided system but switched to scaling system
        //timeCheck = math.max(distance/maxDistance,minSpeed);
        //Time.timeScale = math.min(timeCheck,1);

        prevLeft = posLeft;
        prevRight = posRight;
    }
}