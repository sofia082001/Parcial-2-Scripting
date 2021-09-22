using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bala : MonoBehaviour
{
    Rigidbody rigidPlayer;
    public Vector3 lanzamientoQ;
    public Vector3 lanzamientoW;
    public Vector3 lanzamientoE;
    public Animator animatorExplosion;
    public Animator animatorChica;
    int contador = 0;
    public Text contadorText;
    Transform transformBala;
    public GameObject Panel;
    void Start()
    {
        rigidPlayer = gameObject.GetComponent<Rigidbody>();
        transformBala = gameObject.GetComponent<Transform>();
    }
    void Update()
    {
        animatorExplosion.SetBool("Kaboom", false);
        if (Input.GetKey(KeyCode.Q))
        {
            Q();
        }
        if (Input.GetKey(KeyCode.W))
        {
            W();
        }
        if (Input.GetKey(KeyCode.E))
        {
            E();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cilindro"))
        {
            animatorChica.SetBool("Golpe", true);
            contador++;
            contadorText.text = "GOLPES: " + contador;
        }
        if(other.gameObject.CompareTag("Pared")) 
        {
            animatorChica.SetBool("Falla", true);
        }
        if (other.gameObject.CompareTag("Reset"))
        {
            transformBala.position = new Vector3(-0.1652964f, 0.29f, -7.06f);
            rigidPlayer.velocity = Vector3.zero;
            animatorChica.SetBool("Falla", false);
            animatorChica.SetBool("Golpe", false);
            if(contador == 3) Panel.SetActive(true);
            
        }   
    }
    public void Q()
    {
        rigidPlayer.velocity = lanzamientoQ;
        animatorExplosion.SetBool("Kaboom", true);
    }
    public void W()
    {
        rigidPlayer.velocity = lanzamientoW;
        animatorExplosion.SetBool("Kaboom", true);
    }
    public void E()
    {
        rigidPlayer.velocity = lanzamientoE;
        animatorExplosion.SetBool("Kaboom", true);
    }
}
