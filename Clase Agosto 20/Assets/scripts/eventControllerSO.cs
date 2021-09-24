using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class eventControllerSO : ScriptableObject
{

    public delegate void CambieColorAzul();
    public event CambieColorAzul cambieColorAzul;

    public delegate void CambieColorRojo();
    public event CambieColorRojo cambieColorRojo;

    //public event UnityAction cambiaColor;
    //public event UnityAction<float> cambiaTamano;

    public void CambiarColorEspheraAzul()
    {
        cambieColorAzul?.Invoke();
    }
    public void CambiarColorEspheraRojo()
    {
        cambieColorRojo?.Invoke();
    }




}
