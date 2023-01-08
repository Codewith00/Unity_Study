using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion rotationY = Quaternion.AngleAxis(1, Vector3.up);
        transform.rotation *= rotationY;
        Quaternion rotationX = Quaternion.AngleAxis(1, Vector3.left);
        transform.rotation *= rotationX;
    }
}
