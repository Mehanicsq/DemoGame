using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MagazinControl : MonoBehaviour
{
    public TextMeshProUGUI lotis;

    public Move prups;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lot1()
    {
        prups.coins += Int32.Parse(lotis.text);
        PlayerPrefs.SetInt("coins", prups.coins);
      
        
    }

    
}





