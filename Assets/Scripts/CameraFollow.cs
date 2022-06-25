using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Target.position.x, Target.position.y, -10);
    }
}
