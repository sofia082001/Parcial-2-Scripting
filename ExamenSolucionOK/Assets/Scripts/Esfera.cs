using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Esfera : MonoBehaviour
{
    public Animator RollAnimator;
    public Animator BoomAnimator;
    public Text MarcadorText;
    public GameObject FinJuego;


    public float fuerza = 10;
    public float contador = 0;

    public Vector3 Origen;

    public Vector3 VectorQ;
    public Vector3 VectorW;
    public Vector3 VectorE;

    private Rigidbody _rigidbody;

    public bool SiFueDisparada = false;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(contador >= 3)
            FinJuego.SetActive(true);


        if (SiFueDisparada)
        {
            _rigidbody.useGravity = true;

            return;
        }
        
        _rigidbody.useGravity = false;
        //RollAnimator.SetBool("Lose", false);
        //RollAnimator.SetBool("Win", false);

        if (Input.GetKeyDown(KeyCode.Q))
            DirQ();
        else if (Input.GetKeyDown(KeyCode.W))
            DirW();
        else if (Input.GetKeyDown(KeyCode.E))
            DirE();
    }

    public void DirQ()
    {
        _rigidbody.AddForce(fuerza * VectorQ);
        SiFueDisparada = true;
        BoomAnimator.SetTrigger("Boom");
    }
    public void DirW()
    {
        _rigidbody.AddForce(fuerza * VectorW);
        SiFueDisparada = true;
        BoomAnimator.SetTrigger("Boom");
    }
    public void DirE()
    {
        _rigidbody.AddForce(fuerza * VectorE);
        SiFueDisparada = true;
        BoomAnimator.SetTrigger("Boom");
    }


    public void OnCollisionEnter(Collision other)
    {
        transform.position = Origen;
        _rigidbody.velocity = Vector3.zero;
        SiFueDisparada = false;
        contador = 0;


        if (other.gameObject.tag == "Muro")
        {
            RollAnimator.SetTrigger("LoseT");
            //RollAnimator.SetBool("Win", false);
        }
        if (other.gameObject.tag == "Cilindro")
        {
            RollAnimator.SetTrigger("WinT");
            contador++;
            MarcadorText.text = "Marcador: " + contador;
        }

    }

}
