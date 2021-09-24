using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class sphereController : MonoBehaviour
{
    public Renderer renderlEsfera;

    private void Start()
    {
        renderlEsfera = gameObject.GetComponent<Renderer>();
    }
}
