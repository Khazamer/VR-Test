using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);

        //I tried, need a different system with an update loop
        //gameObject.SetActive(false);
        //System.Threading.Thread.Sleep(3000);
        //gameObject.SetActive(true);
    }
}
