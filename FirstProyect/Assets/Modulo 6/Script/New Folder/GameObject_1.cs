using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_1 : MonoBehaviour
{
    public GameObject PrefabCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Color colorObject = new Color(Random.value, Random.value, Random.value);
        PrefabCube.GetComponent<MeshRenderer>().material.color = colorObject;
    }
}
