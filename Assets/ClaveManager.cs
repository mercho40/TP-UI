using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TMP_InputField inputUsuario;
    public TextMeshProUGUI txtMensaje;


    string usuario = "mercho";
    string clave = "tic2025";
    void Start()
    {
        txtMensaje.text = string.Empty;
    }

    public void ComprobarClaveIngresada()
    {
        string claveIngresada = inputClave.text;
        string usuarioIngresado = inputUsuario.text;
        if (claveIngresada != clave || usuarioIngresado != usuario)
        {
            txtMensaje.text = "Acceso denegado";
            inputClave.text = "";
        }
        else
        {
            txtMensaje.text = "Bienvenido";
        }
    }
}
