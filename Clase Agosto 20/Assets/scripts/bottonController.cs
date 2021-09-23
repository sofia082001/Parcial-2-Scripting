using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bottonController : MonoBehaviour
{
    // Start is called before the first frame update

    public Text Marcador;
    private int marcadornumero = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AumentarMarcador()
    {
        marcadornumero++;
        Marcador.text = marcadornumero.ToString();
    }

    
}
