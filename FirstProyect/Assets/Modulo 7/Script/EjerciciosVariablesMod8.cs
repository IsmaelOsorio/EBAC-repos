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

    private float e = 93.893432234f;

    private string g = "3000";
    private string h = "4000";
    private int i;
    private int j;

    public string f = "Ismael Osorio Cuevas";

    public GameObject Prefab_Cubo;

    public string palabra = "";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Operación entre flotantes: {(int)(c + d)}");

        Debug.Log($"Conversión de flotante a string con 4 posiciones de precisión: {e.ToString("F4")}");

        string nombre = f.Substring(0, 6);
        string apellidoPaterno = f.Substring(7, 6);
        string apellidoMaterno = f.Substring(14, 6);

        string[] nombreCompleto;

        Debug.Log($"Substring\n Nombre: {nombre}\n Apellido Paterno: {apellidoPaterno}\n Apellido Materno: {apellidoMaterno}");

        nombreCompleto = f.Split(' ');

        Debug.Log($"Split\n Nombre: {nombreCompleto[0]}\n Apellido Paterno: {nombreCompleto[1]}\n Apellido Materno: {nombreCompleto[2]}");

        bool success_1 = int.TryParse(g, out i);
        bool success_2 = int.TryParse(h, out j);

        if (success_1 && success_2)
        {
            Debug.Log($"Multiplicación: {i * j}");
        }
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