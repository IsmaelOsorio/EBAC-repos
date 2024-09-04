using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    private Color color;

    private int a   = 0;
    private float b = 2;

    private float c = 3.932f;
    private float d = 9.034f;

    public GameObject Prefab_Cubo;

    public string palabra = "";

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

        switch (palabra)
        {
            case "hola":
                color = new Color(Random.value, Random.value, Random.value);
                Prefab_Cubo.GetComponent<MeshRenderer>().material.color = color;
                break;
        }
    }

    private void FixedUpdate()
    {
        b *= b;
        Debug.Log($"Variable b: {b}");

        if ((a % 2) == 0)
        {
            color = new Color(Random.value, Random.value, Random.value);
            Prefab_Cubo.GetComponent<MeshRenderer>().material.color = color;
        }
    }
}