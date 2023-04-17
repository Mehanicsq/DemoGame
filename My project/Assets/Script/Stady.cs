using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stady : MonoBehaviour
{
    public GameObject stadi1, stadi2, stadi3, stadi4, stadi5;

    private int flag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flag = PlayerPrefs.GetInt("stend");
        if (flag == 1) 
        {
            stadi1.SetActive(false);
            stadi2.SetActive(false);
            stadi3.SetActive(false);
            stadi4.SetActive(false);
            stadi5.SetActive(false);
        } //else stadi1.SetActive(true);
        
    }


    public void openstadi5()
    {
        stadi5.SetActive(false);
        PlayerPrefs.SetInt("stend", 1);
    }


    public void openstadi4()
    {        
        stadi4.SetActive(false);
        stadi5.SetActive(true);

    }

    public void openstadi3()
    {
        stadi4.SetActive(true);
        stadi3.SetActive(false);
    }

    public void openstadi2()
    {
        stadi3.SetActive(true);
        stadi2.SetActive(false);
    }


    public void openstadi1()
    {
        stadi2.SetActive(true);
        stadi1.SetActive(false);
    }
}
