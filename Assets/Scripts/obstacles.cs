using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "barrier") // if the tag of the gameobject is player the pickup gets removed
        {
            Destroy(gameObject);
        }
    }
}
