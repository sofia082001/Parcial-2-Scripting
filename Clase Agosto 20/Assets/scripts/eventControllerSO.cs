<<<<<<< HEAD
﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class eventControllerSO : ScriptableObject
{
    public delegate void CambieColor();
    public event CambieColor cambieColor;

    public delegate void ToggleActivity();
    public event ToggleActivity toggleActivity;

    public void Cambiar_color()
    {
        cambieColor?.Invoke();
    }

    public void ToggleActivity_()
    {
        toggleActivity?.Invoke();
    }
=======
﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class eventControllerSO : ScriptableObject
{
    public delegate void CambieColor();
    public event CambieColor cambieColor;

    public delegate void ToggleActivity();
    public event ToggleActivity toggleActivity;

    public void Cambiar_color()
    {
        cambieColor?.Invoke();
    }

    public void Toggle_Activity()
    {
        toggleActivity?.Invoke();
    }
>>>>>>> main
}