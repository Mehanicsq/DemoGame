using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generated : MonoBehaviour
{
    public GameObject monster;    
    public Transform posgen;
    public bool index = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (index == false)
        {
            Instantiate(monster, posgen.position, Quaternion.Euler(-90, 90, 0));
            index = true;
        }
        
    }
}
