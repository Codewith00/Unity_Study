using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScript : MonoBehaviour
{
    public string action;
    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    public void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
    }
    public void OnMouseUpAsButton()
    {
        switch (action)
        {
            case "play":
                Application.LoadLevel("play");
                break;
            case "star":
                Application.OpenURL("https://music.yandex.ru/home");
                break;
            case "value":
                Application.LoadLevel("value");
                break;
            case "add":
                Application.LoadLevel("add");
                break;
            case "reloud":
                Application.LoadLevel("reloud");
                break;
            case "help":
                Application.LoadLevel("help");
                break;
        }
            
    }
}
