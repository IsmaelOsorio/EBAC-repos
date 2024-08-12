using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Crear_Esferas : MonoBehaviour
{
    public GameObject Prefab_Esferas;
    public List<GameObject> listaCubos;
    public int numCubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        listaCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(Prefab_Esferas);
        tempGameObject.name = "GameObject_Cubo_" + numCubos;
    }
}
