using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonRojo : MonoBehaviour
{
    [SerializeField] eventControllerSO eventoCambiaColor;
    [SerializeField] sphereController sphere;
    IChangeColor _estadoActual;

    private void OnEnable()
    {
        eventoCambiaColor.cambieColorRojo += CambiarColorRojo;

    }
    private void OnDisable()
    {
        eventoCambiaColor.cambieColorRojo -= CambiarColorRojo;
    }

    public void CambiarColorRojo()
    {
        _estadoActual = new Estado_Rojo();
        _estadoActual.ColorCambiar(sphere);

    }
}
