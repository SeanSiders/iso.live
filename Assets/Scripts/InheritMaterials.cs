using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritMaterials : MonoBehaviour
{
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        Renderer [] children = GetComponentsInChildren<Renderer>();        

        foreach (Renderer r in children) r.material = material;
    }
}
