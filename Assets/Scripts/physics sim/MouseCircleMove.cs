using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCircleMove : MonoBehaviour
{
    [SerializeField] public GameObject ball;

    void Update()
    {
        if(Input.GetButton("Fire3")){

            ball.transform.position = 
            ball.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);
        }
    }
}
