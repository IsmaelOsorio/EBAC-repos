using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Esfera : MonoBehaviour
{
    public GameObject Prefab_Esfera;
    public bool Bool_Esfera;

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
        Bool_Esfera = !Bool_Esfera;

        if (Bool_Esfera) c = new Color(255, 255, 255);
        else c = new Color(0, 0, 0);

        Prefab_Esfera.GetComponent<MeshRenderer>().material.color = c;
    }
}
