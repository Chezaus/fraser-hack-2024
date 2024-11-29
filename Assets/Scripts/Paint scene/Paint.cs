using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    [SerializeField] GameObject paint;
    [SerializeField] GameObject erase;
    Vector3 mousePosition;

    void Update(){

        Vector3 mousePosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);

        if(Input.GetButton("Fire")){

            GameObject newPaint = (GameObject)Instantiate(paint, mousePosition, Quaternion.identity);
        }

        if(Input.GetButton("Fire2")){
            GameObject newErase = (GameObject)Instantiate(erase, mousePosition, Quaternion.identity);
            
        }

        if(Input.GetButton("Fire3")){
            GameObject[] gos = GameObject.FindGameObjectsWithTag("paint");
            foreach(GameObject go in gos)
            Destroy(go);
        }
    }
}
