using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Buy : MonoBehaviour
{
    public Move prups;
    public EnterFly prups1;


    public TextMeshProUGUI cena;

    public GameObject buyd;
    public GameObject pokupka;
    
    public GameObject vibor;

    public int id;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buyflay()
    {
        if (prups.coins > Int32.Parse(cena.text))
        {
            prups.coins -= Int32.Parse(cena.text);
            PlayerPrefs.SetInt("coins", prups.coins);

            buyd.SetActive(false);
            pokupka.SetActive(false);            
            vibor.SetActive(true);

            id = prups1.index;
            if (id == 0) 
            {
                PlayerPrefs.SetInt("sm1", id);
            }
            if (id == 1)
            {
                PlayerPrefs.SetInt("sm2", id);
            }
            if (id == 2)
            {
                PlayerPrefs.SetInt("sm3", id);
            }
            if (id == 3)
            {
                PlayerPrefs.SetInt("sm4", id);
            }





        }
    }


}
