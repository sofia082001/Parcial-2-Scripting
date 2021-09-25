using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botonDeCambiarTexto : MonoBehaviour
{
    public Text nombre;
    public Text textoNuevo;

    public void AparecerTexto()
    {
        textoNuevo.text = "Hola " + nombre.text.ToString()+ " como estas";
    }

}
