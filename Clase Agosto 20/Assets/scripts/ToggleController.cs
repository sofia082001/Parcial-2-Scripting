using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{
    IToggleState estado;
    
    public void Activado(Text textoActivado)
    {
        estado = new OnState();
        estado.MyState(textoActivado);
    }
    public void Apagado(Text textoApagado)
    {
        estado = new OffState();
        estado.MyState(textoApagado);
    }
}
