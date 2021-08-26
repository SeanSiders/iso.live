using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateChildren : MonoBehaviour
{
    public GameObject [] children;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject child in children) Instantiate(child, transform);
    }
}
