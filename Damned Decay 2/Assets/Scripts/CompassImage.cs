using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassImage : MonoBehaviour
{
    public Transform player;
    Vector3 dir; // dir = direction

    void Update()
    {
        dir.z = player.eulerAngles.y; // players direction is where This will point
        transform.localEulerAngles = dir;
    }
}
