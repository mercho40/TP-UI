using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TMP_InputField inpuClave;
    public TextMeshProUGUI txtMensaje;
    string clave = "tic2025";
    void Start()
    {
        txtMensaje.text = string.Empty;
    }

    public void ComprobarClaveIngresada()
    {
        string claveIngresada = inpuClave.text;
        if (claveIngresada != clave)
        {
            txtMensaje.text = "Acceso denegado";
            inpuClave.text = "";
        }
        else
        {
            txtMensaje.text = "Bienvenido";
        }
    }
}
