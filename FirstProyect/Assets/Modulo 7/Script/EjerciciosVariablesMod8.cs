using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    private int a   = 0;
    private float b = 2;
    // Start is called before the first frame update
    void Start()
    {
        
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
