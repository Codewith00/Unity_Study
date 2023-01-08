using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public float speed;
    private Vector3 target = new Vector3(0, 0.6f, -1f);
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != -0.6f)
        {
            target.y = -0.6f;
        }
        else { if (transform.position == target && target.y == -0.6f) target.y = 0.6f; }
        
    }
}
