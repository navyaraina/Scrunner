using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationBall : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;
    public GameObject player;
    
    void Update()
    {
        player.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
