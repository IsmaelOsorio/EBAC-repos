using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_3 : MonoBehaviour
{
    public GameObject PrefabCapsule;

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
        Color colorObject = new Color(Random.value, Random.value, Random.value);
        PrefabCapsule.GetComponent<MeshRenderer>().material.color = colorObject;
    }
}
