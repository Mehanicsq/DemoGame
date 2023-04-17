using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Up : MonoBehaviour
{
    public Move prups;

    public string nameup;
    public string up;

    public int parametr;
    public int cenaparametr;

    public int cenaparametr1;
    public int cenaparametr2;
    public int cenaparametr3;


    private int k1 = 1;
    private int k2 = 1;
    private int k3 = 1;


    public int indexcontrol;

    public TextMeshProUGUI txtnameup;
    public TextMeshProUGUI txtup;
    public TextMeshProUGUI txtcenaparametr;

    public Slider bar1;
    public Slider bar2;
    public Slider bar3;
    public float lvlfuel;
    public float lvlboolet;
    public float lvlhp;






    // Start is called before the first frame update
    void Start()
    {
       

        lvlhp = PlayerPrefs.GetInt("lvlhp");
        lvlfuel = PlayerPrefs.GetInt("lvlfuel");
        lvlboolet = PlayerPrefs.GetInt("lvlboolet");

    }

    // Update is called once per frame
    void Update()
    {
       

        lvlhp = PlayerPrefs.GetInt("lvlhp");
        lvlfuel = PlayerPrefs.GetInt("lvlfuel");
        lvlboolet = PlayerPrefs.GetInt("lvlboolet");

        if (indexcontrol == 1) 
        {
            cenaparametr1 = PlayerPrefs.GetInt("cenaparametr1");
            txtcenaparametr.text = " " + (cenaparametr1 + 15 * k1);
            txtnameup.text = nameup;
            txtup.text = up + " " + prups.cfuel + "(+" + parametr + ")";
            if (lvlfuel > 0)
            {
                k1 = 0;
            }
        }
        if (indexcontrol == 2)
        {
            txtnameup.text = nameup;
            txtup.text = up + " " + prups.cspeed + "(+" + parametr + ")";
        }
        if (indexcontrol == 3)
        {
            cenaparametr2 = PlayerPrefs.GetInt("cenaparametr2");
            txtcenaparametr.text = " " + (cenaparametr2 + 25 * k2);
            txtnameup.text = nameup;
            txtup.text = up + " " + prups.cBoolet + "(+" + parametr + ")";
            if (lvlboolet > 0)
            {
                k2 = 0;
            }
        }
        if (indexcontrol == 4)
        {
            cenaparametr3 = PlayerPrefs.GetInt("cenaparametr3");

            txtcenaparametr.text = " " + (cenaparametr3 + 50 * k3);
            txtnameup.text = nameup;
            txtup.text = up + " " + prups.chp + "(+" + parametr + ")";
            if (lvlhp > 0)
            {
                k3 = 0;
            }
        }
        cenaparametr1 = PlayerPrefs.GetInt("cenaparametr1");
        cenaparametr2 = PlayerPrefs.GetInt("cenaparametr2");
        cenaparametr3 = PlayerPrefs.GetInt("cenaparametr3");

        

        if (false)
        {
            PlayerPrefs.SetInt("lvlfuel", 0);
            PlayerPrefs.SetInt("lvlboolet", 0);
            PlayerPrefs.SetInt("lvlhp", 0);
        }

        bar1.value = lvlfuel / 4f;
        bar2.value = lvlboolet / 4f;
        bar3.value = lvlhp / 4f;

    }

    public void upparam() 
    {
        if (indexcontrol == 1 )
        {
            if (prups.coins > cenaparametr && lvlfuel < 4) 
            {
                prups.cfuel += parametr;
                prups.coins -= cenaparametr;
                cenaparametr += cenaparametr * (int)lvlfuel;

                lvlfuel += 1f;
                bar1.value = lvlfuel / 4f;
                PlayerPrefs.SetInt("cenaparametr1", cenaparametr);

                PlayerPrefs.SetInt("lvlfuel", (int)lvlfuel);
                PlayerPrefs.SetInt("coins", prups.coins);
                PlayerPrefs.SetInt("cfuel", (int)prups.cfuel);
        

            }
        }
        if (indexcontrol == 2)
        {
            prups.cspeed += parametr;
        }
        if (indexcontrol == 3)
        {
            if (prups.coins > cenaparametr && lvlboolet < 4)
            {
                prups.cBoolet += parametr;
                prups.coins -= cenaparametr;
                
                cenaparametr += cenaparametr * (int)lvlboolet;

                lvlboolet += 1f;
                bar2.value = lvlboolet / 4f;
                PlayerPrefs.SetInt("cenaparametr2", cenaparametr);
                PlayerPrefs.SetInt("cBoolet", (int)prups.cBoolet);
                PlayerPrefs.SetInt("lvlboolet", (int)lvlboolet);
                PlayerPrefs.SetInt("coins", prups.coins);

            }
        }
        if (indexcontrol == 4 )
        {
            if (prups.coins > cenaparametr && lvlhp < 4)
            {
                prups.chp += parametr;
                prups.coins -= cenaparametr;
                cenaparametr += cenaparametr * ((int)lvlhp);

                lvlhp += 1f;
                bar3.value = lvlhp / 4f;
                PlayerPrefs.SetInt("cenaparametr3", cenaparametr);

                PlayerPrefs.SetInt("lvlhp", (int)lvlhp);
                PlayerPrefs.SetInt("coins", prups.coins);
                PlayerPrefs.SetInt("chp", (int)prups.chp);
              
            }
        }

    }

    

}
