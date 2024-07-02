using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        i = 1;
        //Debug.Log("Hello World");
        //Debug.LogError("Hello World Error");
        //Debug.LogWarning("Hello World Warning");
    }

    // Update is called once per frame
    void Update()
    {
        //i++;
        //Debug.Log("Valor i: " + i);

        Debug.Log("Hola desde Update");
    }

    private void FixedUpdate()
    {
        Debug.Log("Hola desde Fixed Update cada 50px");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }

    private void OnEnable()
    {
        Debug.Log("Objeto habilitado");
    }

    private void OnDisable()
    {
        Debug.Log("Objeto inhabilitado");
    }
}
