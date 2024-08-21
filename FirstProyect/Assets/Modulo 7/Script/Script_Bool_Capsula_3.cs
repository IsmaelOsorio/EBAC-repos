using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Capsula_3 : MonoBehaviour
{
    public GameObject Prefab_Capsula;

    public Script_Capsula capsula;
    public Script_Capsula_2 capsula_2;

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

        if ((capsula.cubo.Bool_Cubo && capsula.esfera.Bool_Esfera) || (capsula_2.cubo.Bool_Cubo && capsula_2.esfera.Bool_Esfera)) c = new Color(255, 255, 255);
        else c = new Color(0, 0, 0);

        Prefab_Capsula.GetComponent<MeshRenderer>().material.color = c;
    }
}
