using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public GameObject boolet;
    public Transform trpos;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shotbool() 
    {
        Instantiate(boolet, trpos.position, trpos.rotation * Quaternion.Euler(0, 0, 0));
    }
}
