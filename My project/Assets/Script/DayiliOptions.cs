using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DayiliOptions : MonoBehaviour
{
    public Move prups;


    public int min = 0;
    public float sec = 0;



    public TextMeshProUGUI txttime;
    public DateTime mytime1;
    public DateTime mytime2;
    public string mytime3;


    public int indexday;
    public int Controlget;


    public TextMeshProUGUI[] dailybonus1;

  
    public TextMeshProUGUI txtdailytime;
    public TextMeshProUGUI daydailybonus;

    public GameObject[] daydailybonusgetimg;

    public int daydailybonusmone = 25;


    public int Controlgetdey = 0;

    public int cnttm = 0;
    public int btt = 0;








    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        


        min = PlayerPrefs.GetInt("time");
        sec = PlayerPrefs.GetFloat("timesec");
        sec += Time.deltaTime;

        if (sec > 60) 
        {
            sec = 0;
            min += 1;
        }

        PlayerPrefs.SetInt("time", min);
        PlayerPrefs.SetFloat("timesec", sec);


        if (min >= 5 && cnttm == 0) 
        {
            daydailybonus.text = daydailybonusmone.ToString();                     
        }
        if (min >= 10 && cnttm == 1)
        {
            daydailybonus.text = (daydailybonusmone*2).ToString();
        }
        if (min >= 25 && cnttm == 2)
        {
            daydailybonus.text = (daydailybonusmone * 4).ToString();
        }
       









        txtdailytime.text = PlayerPrefs.GetInt("time") + ":" + Math.Round(sec).ToString();









        mytime1 = DateTime.Today;
        mytime3 = PlayerPrefs.GetString("ddt");
        if (mytime3 == "")
        {
            mytime3 = "2000.2.2";
        }
        mytime2 = DateTime.Parse(mytime3);
        indexday = PlayerPrefs.GetInt("indexday");
        

        if (mytime1 > mytime2) 
        {           
            PlayerPrefs.SetString("ddt", mytime1.ToString());  
            PlayerPrefs.SetInt("Controlget", Controlget);
            Controlget = PlayerPrefs.GetInt("Controlget");
            PlayerPrefs.SetInt("btt", 0);
            PlayerPrefs.SetInt("cnttm", 0);

            PlayerPrefs.SetInt("time", 0);
            PlayerPrefs.SetFloat("timesec", 0);


        }
        txttime.text = mytime2.ToString();

        if (indexday-1 >= 0) 
        {
            daydailybonusgetimg[0].SetActive(true);
        } 
        else daydailybonusgetimg[0].SetActive(false);
        if (indexday - 1 >= 1)
        {
            daydailybonusgetimg[1].SetActive(true);
        }
        else daydailybonusgetimg[1].SetActive(false);
        if (indexday - 1 >= 2)
        {
            daydailybonusgetimg[2].SetActive(true);
        }
        else daydailybonusgetimg[2].SetActive(false);
        if (indexday - 1 >= 3)
        {
            daydailybonusgetimg[3].SetActive(true);
        }
        else daydailybonusgetimg[3].SetActive(false);
        if (indexday - 1 >= 4)
        {
            daydailybonusgetimg[4].SetActive(true);
        }
        else daydailybonusgetimg[4].SetActive(false);
        if (indexday - 1 >= 5)
        {
            daydailybonusgetimg[5].SetActive(true);
        }
        else daydailybonusgetimg[5].SetActive(false);
        if (indexday == 6)
        {
            PlayerPrefs.SetInt("indexday", 0);
        }
       

    }

    public void getdailybonus()
    {

        if (PlayerPrefs.GetInt("Controlget") == 0) {
            if (indexday == 2 || indexday == 5)
            {
                prups.gem += Int32.Parse(dailybonus1[indexday].text);
                PlayerPrefs.SetInt("gems", prups.gem);
            } else prups.coins += Int32.Parse(dailybonus1[indexday].text);
            PlayerPrefs.SetInt("coins", prups.coins);
            Controlget = 1;
            PlayerPrefs.SetInt("Controlget", Controlget);
            indexday += 1;
            PlayerPrefs.SetInt("indexday", indexday);
        }
    }

    public void geteveredaylibonus() 
    {
        // if (Controlgetdey != 1) {
        btt = PlayerPrefs.GetInt("btt");
        cnttm = PlayerPrefs.GetInt("cnttm");




        if (min >= 10 && btt == 1)
        {
            btt += 1;
            cnttm += 1;
            prups.coins += Int32.Parse(daydailybonus.text);
            PlayerPrefs.SetInt("coins", prups.coins);
        }
        if (min >= 5 && btt == 0)
        {
            btt += 1;
            cnttm += 1;
            prups.coins += Int32.Parse(daydailybonus.text);
            PlayerPrefs.SetInt("coins", prups.coins);
        }
        PlayerPrefs.SetInt("btt", btt);
        PlayerPrefs.SetInt("cnttm", cnttm);








        //  }


    }

   

}
