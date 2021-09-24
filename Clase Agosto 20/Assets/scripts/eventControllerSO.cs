using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class eventControllerSO : ScriptableObject
{
    public delegate void CambieColor();
    public event CambieColor cambieColor;

<<<<<<< Updated upstream
    public void Cambiar_color()
=======
    public delegate void CambieColorAzul();
    public event CambieColorAzul cambieColorAzul;

    public delegate void CambieColorRojo();
    public event CambieColorRojo cambieColorRojo;

    public delegate void CambieColor();
    public event CambieColor cambieColor; 

    //public event UnityAction cambiaColor;
    //public event UnityAction<float> cambiaTamano;

    public void CambiarColorEspheraAzul()
    {
        cambieColorAzul?.Invoke();
    }
    public void CambiarColorEspheraRojo()
>>>>>>> Stashed changes
    {
        cambieColor?.Invoke();
    }
}