using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class sphereController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambiarTamano(Single valor)
    {
        transform.localScale = Vector3.one * valor*10;
    }
}
