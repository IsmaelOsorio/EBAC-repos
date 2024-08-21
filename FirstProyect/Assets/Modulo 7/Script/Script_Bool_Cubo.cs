using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Cubo : MonoBehaviour
{
    public GameObject Prefab_Cubo;
    public bool Bool_Cubo;

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
        Bool_Cubo = !Bool_Cubo;

        if (Bool_Cubo) c = new Color(255, 255, 255);
        else c = new Color(0, 0, 0);

        Prefab_Cubo.GetComponent<MeshRenderer>().material.color = c;
    }
}
