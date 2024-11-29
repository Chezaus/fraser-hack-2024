using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SignIn : MonoBehaviour
{
    public Image button;

    public void OnClick()
    {    
        SceneManager.LoadScene("physicsSimulation");
    }
}
