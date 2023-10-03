using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new123 : MonoBehaviour
{
    public GameObject Sphere;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Activated");
            Sphere.SetActive(true);
        }

        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Deactivated");
            Sphere.SetActive(false);
        }
    }
}
