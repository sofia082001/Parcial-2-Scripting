using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botonDeCambiarTexto : MonoBehaviour
{
    public Text nombre;
    public Text textoNuevo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AparecerTexto()
    {
        textoNuevo.text = "Hola " + nombre.text.ToString()+ " como estas";
    }

}
