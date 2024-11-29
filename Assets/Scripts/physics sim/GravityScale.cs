using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GravityScale : MonoBehaviour
{
    public float gravityScale = 9.8f; 
    [SerializeField] Slider slider;
    public TMP_Text text;
    

    public void ChangeGravity(){

        gravityScale = -slider.value;
        Physics2D.gravity = new Vector2(0f,gravityScale);

        text.text = gravityScale.ToString();
    }


}
