using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{

    public Transform player;
    public Vector3 pos;

    void Update()
    {
        transform.position = player.transform.position + pos;
    }
}
