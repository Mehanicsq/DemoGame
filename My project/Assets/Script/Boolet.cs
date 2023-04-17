using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boolet : MonoBehaviour
{
    public GameObject boolet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        boolet.transform.Translate(new Vector3(1f, 0, 0) * 10  * Time.deltaTime);
    }
}
