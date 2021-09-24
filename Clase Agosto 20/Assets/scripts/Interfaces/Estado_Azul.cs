using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado_Azul : IChangeColor
{
    public void ColorCambiar(sphereController sphere)
    {
        sphere.renderlEsfera.material.color = Color.blue;
        Debug.Log("entre en estado Azul");
    }
}
