using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Esfera : MonoBehaviour
{
    public GameObject Prefab_Esfera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        Prefab_Esfera.GetComponent<MeshRenderer>().material.color = c;
    }
}
