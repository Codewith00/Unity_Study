using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFloat : MonoBehaviour
{
    public float speed;
    public Vector3 target;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }
}
