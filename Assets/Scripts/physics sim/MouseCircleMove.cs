using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCircleMove : MonoBehaviour
{
    [SerializeField] public GameObject ball;

    void Update()
    {
        if(Input.GetButton("Fire3")){

            
            ball.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);
        }
    }

    GameObject getGameObjectAtPosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
            Debug.Log("found " + hit.collider.gameObject.name + " at distance: " + hit.distance);
            return hit.collider.gameObject;
        }
}
