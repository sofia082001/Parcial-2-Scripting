using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonAzul : MonoBehaviour
{

    [SerializeField] eventControllerSO eventoCambiaColor;
    [SerializeField] sphereController sphere;
    IChangeColor _estadoActual;

    
    private void OnEnable()
    {
        eventoCambiaColor.cambieColorAzul += CambiarColorAzul;

    }
    private void OnDisable()
    {
        eventoCambiaColor.cambieColorAzul -= CambiarColorAzul;
    }

    public void CambiarColorAzul()
    {
        _estadoActual = new Estado_Azul();
        _estadoActual.ColorCambiar(sphere);

    }




}
