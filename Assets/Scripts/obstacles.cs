using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacles : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "env")
            SceneManager.LoadScene("loadingscene");

        if (other.gameObject.tag == "gems")
        {
            rb.isKinematic = false;
            other.gameObject.SetActive(false);
        }
    }
}
