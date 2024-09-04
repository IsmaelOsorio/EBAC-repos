using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    private int a =     0;
    private float b =   0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a += a;
        Debug.Log(a);
    }

    private void FixedUpdate()
    {
        b *= b;
        Debug.Log(b);
    }
}
