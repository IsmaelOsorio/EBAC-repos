using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios_de_Ciclos_y_arreglos : MonoBehaviour
{
    private int[] array_1;
    private int[] array_2;
    private int[] array_3;

    private string[] array_4;

    private int[,] array_5;
    private int[] array_6;
    private int[] array_7;

    // Start is called before the first frame update
    void Start()
    {
        // Primera sentencia
        array_1 = new int[5];
        array_2 = new int[5];
        array_3 = new int[5];

        for (int i = 0; i < 5; i++)
        {
            array_1[i] = Random.Range(0, 10);
            array_2[i] = Random.Range(10, 20);

            Debug.Log($"Array 1: {array_1[i]} \nArray 2: {array_2[i]}");
        }

        for (int i = 0; i < 5; i++)
        {
            array_3[i] = array_1[i] + array_2[i];

            Debug.Log($"Array 3: {array_3[i]}");
        }

        // Segunda sentencia
        array_4 = new string[5] { "Aprende", "a vivir", "y sabrás", "morir", "bien" };
        string fraseCelebre = "";

        foreach (string palabra in array_4)
        {
            fraseCelebre += (palabra + ' ');
        }

        Debug.Log(fraseCelebre);

        // Tercera sentencia
        array_5 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        array_6 = new int[3] { 1, 2, 3 };
        array_7 = new int[array_5.GetLength(0)];

        for (int i = 0; i < array_5.GetLength(0); i++)
        {
            for (int j = 0; j < array_6.Length; j++)
            {
                array_7[i] += (array_5[i, j] * array_6[j]);
            }
        }

        foreach (int i in array_7)
        {
            Debug.Log($"Array 7: {i}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
