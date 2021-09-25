using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffState : IToggleState
{
    public void MyState(Text texto)
    {
        texto.text = "Estado Apagado";
    }
}
