using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnState : IToggleState
{
    public void MyState(Text texto)
    {
        texto.text = "Estado Prendido";
    }
}
