using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GravityScale : MonoBehaviour
{
    public float gravityScale = 9.8f; 
    float value;
    [SerializeField] Image bar;

    void Start(){

        Physics2D.gravity = new Vector2(0, -gravityScale);
    }

    void Update(){

        Physics2D.gravity = new Vector2(0, -gravityScale);

        if(gravityScale < 0)  {value = 1;}
        else{value = (float)gravityScale/19.6f;}

            bar.fillAmount = value;
    }

    public void mars(){

        gravityScale = 3.71f;
    }
}
