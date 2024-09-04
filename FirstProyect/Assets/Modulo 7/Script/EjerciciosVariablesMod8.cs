using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    private int a   = 0;
    private float b = 2;

    private float c = 3.932f;
    private float d = 9.034f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Operación entre flotantes: {(int)(c + d)}");
    }

    // Update is called once per frame
    void Update()
    {
        a++;
        Debug.Log($"Variable a: {a}");
    }

    private void FixedUpdate()
    {
        b *= b;
        Debug.Log($"Variable b: {b}");
    }
}
