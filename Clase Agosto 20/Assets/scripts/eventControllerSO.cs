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

    public void Cambiar_color()
    {
        cambieColor?.Invoke();
    }
}