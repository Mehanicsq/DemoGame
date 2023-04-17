using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppers : MonoBehaviour
{
    public GameObject up1;
    public GameObject up2;
    public GameObject up3;
    public GameObject up4;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ups1() 
    {
        up1.SetActive(true);
        up2.SetActive(false);
        up3.SetActive(false);
        up4.SetActive(false);
    }
    public void ups2()
    {
        up1.SetActive(false);
        up2.SetActive(true);
        up3.SetActive(false);
        up4.SetActive(false);
    }
    public void ups3()
    {
        up1.SetActive(false);
        up2.SetActive(false);
        up3.SetActive(true);
        up4.SetActive(false);
    }
    public void ups4()
    {
        up1.SetActive(false);
        up2.SetActive(false);
        up3.SetActive(false);
        up4.SetActive(true);
    }
}
