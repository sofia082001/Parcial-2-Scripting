using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindro : MonoBehaviour
{
    public Vector3 dirVector3 = Vector3.right;

    public float VelMovimiento = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        //Time.deltaTime
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dirVector3*VelMovimiento;
    }
}
