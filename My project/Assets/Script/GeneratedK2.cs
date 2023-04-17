using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedK2 : MonoBehaviour
{
    public GameObject[] komnata;
    public Transform posgen;
    public bool index = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Monster")
        {
           
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (index == false)
        {
            Instantiate(komnata[Random.Range(0, komnata.Length)], posgen.position, Quaternion.Euler(-90, 90, 0));
            index = true;
        }
    }
}
