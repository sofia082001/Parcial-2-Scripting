using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado_Rojo : IChangeColor
{
    public void ColorCambiar(sphereController sphere)
    {
        sphere.renderlEsfera.material.color = Color.red;
        Debug.Log("entre en estado rojo");
    }
}
