using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Capsula : MonoBehaviour
{
    public GameObject Prefab_Capsula;

    public Script_Cubo cubo;
    public Script_Esfera esfera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Color c;

        if (cubo.Bool_Cubo && esfera.Bool_Esfera) c = new Color(255, 255, 255);
        else c = new Color(0, 0, 0);

        Prefab_Capsula.GetComponent<MeshRenderer>().material.color = c;
    }
}
