using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_2 : MonoBehaviour
{
    public GameObject PrefabSphere;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Color colorObject = new Color(Random.value, Random.value, Random.value);
        PrefabSphere.GetComponent<MeshRenderer>().material.color = colorObject;
    }
}
