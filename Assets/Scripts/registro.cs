using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class registro : MonoBehaviour
{
    public InputField ifNombre;
    public static string nombreReg;

    public void registroNombre(){
        if (ifNombre.text != "")
        {
            nombreReg = ifNombre.text;
            SceneManager.LoadScene("main");
        }
    }
}
