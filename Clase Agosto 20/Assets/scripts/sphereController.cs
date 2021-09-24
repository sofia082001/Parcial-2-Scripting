using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.UI;

public class sphereController : MonoBehaviour
{
    [SerializeField] eventControllerSO eventoCambiaColor;


    IChangeColor _estadoActual;

    public Renderer renderlEsfera;

    private void Start()
    {
        renderlEsfera = gameObject.GetComponent<Renderer>();
    }
    private void OnEnable()
    {
        eventoCambiaColor.cambieColor += CambiarColor;
    }
    private void OnDisable()
    {
        eventoCambiaColor.cambieColor -= CambiarColor;
    }
    public void CambiarColor()
    {
        _estadoActual = new Estado_Rojo();
        _estadoActual.ColorCambiar(this);

    }
}
