using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
