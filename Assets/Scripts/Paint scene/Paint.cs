using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    GameObject paint;
    void Update(){

        if(Input.GetButton("Fire")){

            GameObject newBall = (GameObject)Instantiate(paint, mousePosition, Quaternion.identity);
        }
    }
}
