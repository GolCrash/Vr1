using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public GameObject sphere;

    public void Button()
    {
        if(sphere.active == false)
        {
            Debug.Log("deactivated");
        }

        if (sphere.active == true)
        {
            Debug.Log("activated");
        }
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
