using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirCilindro : MonoBehaviour
{
    public Vector3 dirCilindro = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Cilindro obj = other.GetComponent<Cilindro>();
        obj.dirVector3 = dirCilindro;

    }
}
