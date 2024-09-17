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

    float minSpeed = 0.1f;

    public float factor = 200f;

    float smoothSpeed = 2f;

    float distance;

    float scaledDistance;

    float targetTimeScale;

    float timeCheck;

    //public float maxDistance = 0.005f;

    float startDeltaTime;

    // Start is called before the first frame update
    void Start()
    {
        //trigger.action.performed
        prevLeft = leftHand.transform.position;
        prevRight = rightHand.transform.position;

        startDeltaTime = Time.fixedDeltaTime;
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

        //float targetTimeScale = Mathf.Clamp(scaledDistance, minSpeed, 1f);

        //Smooth out issues
        /*
        if(scaledDistance < 0.1f) {
            Time.timeScale = 0.1f;
        }
        else {
            Time.timeScale = Mathf.Lerp(Time.timeScale, targetTimeScale, Time.deltaTime * smoothSpeed);
        }
        */

        //Old stuff
        //timeCheck = math.max(scaledDistance,minSpeed);
        //Time.timeScale = math.min(timeCheck,1);

        //Best code
        Time.timeScale = Mathf.Clamp(scaledDistance, minSpeed, 1f);
        //Time.fixedDeltaTime = startDeltaTime * Time.timeScale;
        
        //Time.fixedDeltaTime = 0.02F * Time.timeScale;
        
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