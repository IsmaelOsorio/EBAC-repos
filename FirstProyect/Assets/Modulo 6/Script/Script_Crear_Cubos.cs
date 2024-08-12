using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Crear_Cubos : MonoBehaviour
{
    public GameObject Prefab_Cubo;
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
        
    }

    private void Awake()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(Prefab_Cubo);
        tempGameObject.name = "GameObject_Cubo_" + numCubos;
    }
}