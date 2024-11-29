using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField] public GameObject ball;

    Vector3 mousePosition;

    private float cooldown;

    void Update(){

        cooldown += Time.deltaTime;

        if(cooldown >= 1)
        {
            Vector3 mousePosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);

            if(Input.GetButton("Fire2")){

                GameObject newBall = (GameObject)Instantiate(ball, mousePosition, Quaternion.identity);

                cooldown = 0f;

            }
        }
    }
}
