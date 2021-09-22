using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindro : MonoBehaviour
{
    public Vector3 velocidadLateralCilindro;
    public Vector3 velocidadAlturaCilindro;
    Rigidbody rigidCilindro;
    void Start()
    {
        rigidCilindro = gameObject.GetComponent<Rigidbody>();

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("GOder"))
        {
            rigidCilindro.velocity = velocidadLateralCilindro;
        }
        if (collision.gameObject.CompareTag("GOarriba"))
        {
            rigidCilindro.velocity = velocidadAlturaCilindro;
        }
        if (collision.gameObject.CompareTag("GOizq"))
        {
            rigidCilindro.velocity = -velocidadLateralCilindro;
        }
        if (collision.gameObject.CompareTag("GOabajo"))
        {
            rigidCilindro.velocity = -velocidadAlturaCilindro;
        }

    }

}
