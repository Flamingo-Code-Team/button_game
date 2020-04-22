using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class level_2 : MonoBehaviour
{
    public GameObject Triangle;
    public Vector3 buf_v3;
    private int num = 1;
    public float speed = 1;
    private void Start()
    {
        buf_v3 = Triangle.GetComponent<Transform>().position;
    }
    void FixedUpdate()
    {
        if (num % 2 != 0)
        {
            if (Triangle.GetComponent<Transform>().transform.position.y < buf_v3.y + 200)
            {
                Triangle.GetComponent<Transform>().localPosition += Vector3.up * speed;
            }
            else num++;
        }
        else
        {
            if (Triangle.GetComponent<Transform>().transform.position.y > buf_v3.y)
            {
                Triangle.GetComponent<Transform>().localPosition -= Vector3.up * speed;
            }
            else num++;
        }
        if(Triangle.GetComponent<Transform>().transform.position.y == -220) Debug.Log("You are WINER triangle");
    }
}
