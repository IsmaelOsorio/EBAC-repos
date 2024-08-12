using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld_2 : MonoBehaviour
{
    private int cont = 0;

    //private void Awake()
    //{
    //    Debug.LogError("Awake es el : " + ++cont + "° en ejecutarse");
    //}
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError("Start es el " + ++cont + "° en ejecutarse");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("Update es el " + ++cont + "° en ejecutarse");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate es el " + ++cont + "° en ejecutarse");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate es el " + ++cont + "° en ejecutarse");
    }
}
