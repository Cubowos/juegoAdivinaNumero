using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class adivina : MonoBehaviour
{
    public Text imprimeNombre, txtResultado;
    public InputField ifNumero;
    public Button btnVerificar, btnReiniciar;

    private int numeroAleatorio;
    private int numIntentos = 0;

    // Start is called before the first frame update
    private void Start()
    {
        numeroAleatorio = Random.Range(1, 100);
        imprimeNombre.text = "Hola " + registro.nombreReg + " adivina entre un numero entre 1 y 100 ";
        btnReiniciar.gameObject.SetActive(false); //oculta el boton
    }
       
    public void VerificarNumero()
    {
        int a = -1;
        if(ifNumero.text != "")
        {
            a = int.Parse(ifNumero.text);
        }
        if (a > numeroAleatorio)
        {
            numIntentos++;
            txtResultado.text = registro.nombreReg + "el valor introducido debe de ser menor";

        }
        else if (a < numeroAleatorio)
        {
            numIntentos++;
            txtResultado.text = registro.nombreReg + "el valor introducido debe de ser mayor";
        }
        else
        {
            txtResultado.text = "Felicidades " + registro.nombreReg + " el numero era " + numeroAleatorio.ToString();
            txtResultado.text += "\n adivinaste en " + numIntentos.ToString() + " intentos";
            btnReiniciar.gameObject.SetActive(false);
            btnVerificar.gameObject.SetActive(true);
        }
        ifNumero.text = "";
        }
    public void Reinicia()
    {
        SceneManager.LoadScene("Inicio");
    }
}
