using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandCol : MonoBehaviour
{
    public bool main = false, right = false;
    private static Color aColor;
    public void Awake()
    {
        if (main)
            aColor = new Vector4(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), 1);
    }
    void Start()
    {
        if (main || right) {
            GetComponent<Renderer>().material.color = aColor;
        }
        else {
            GetComponent<Renderer>().material.color = new Vector4(aColor.r + Random.Range(0.1f, 1f), aColor.g + Random.Range(0.1f, 1f),
         aColor.b + Random.Range(0.1f, 1f));
        }
    }

}
