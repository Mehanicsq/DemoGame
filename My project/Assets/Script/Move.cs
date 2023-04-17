using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Move : MonoBehaviour
{
    public Menu gameover;
    public EnterFly model;
    public EnterFly bonusrec;

    public GameObject modelsamoleta1;
    public GameObject modelsamoleta2;
    public GameObject modelsamoleta3;
    public GameObject modelsamoleta4;

    public int testp;

    public GameObject shotboton;



    public float hp;
    public float speed;
    public float Boolet;
    public float fuel;

    public float chp;
    public float cspeed;
    public float cBoolet;
    public float cfuel;

    public int score;
    public int scorerecord;
    public TextMeshProUGUI scorerecordtxt;
    public TextMeshProUGUI scoreTXT;
    public TextMeshProUGUI scoreGOTXT;
    public TextMeshProUGUI goldGOTXT;
    public int coinsGO;










    public Text txthp;
    public Text txtspeed;
    public Text txtBoolet;
    public Text txtfuel;


    



    public float spcontrol = 0f;
    public GameObject somolet;

    public TextMeshProUGUI coinsTXT;
    public int coins;

    public TextMeshProUGUI gemTXT;
    public int gem;

    private int cntindxstart = 0;
    private string str;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            bonusrec.perk2 = PlayerPrefs.GetInt("perk2");
            coins += 200 * bonusrec.perk2;            
            PlayerPrefs.SetInt("coins", coins);
            coinsTXT.text = coins.ToString();
            coinsGO += 200 * bonusrec.perk2;
            goldGOTXT.text = coinsGO.ToString();
            Destroy(other.gameObject);
        }
    }



        // Start is called before the first frame update
        void Start()
    {
        cntindxstart = PlayerPrefs.GetInt("cntindxstart");
        if (cntindxstart == 0) {
            PlayerPrefs.SetInt("chp", (int)chp);
            PlayerPrefs.SetInt("cBoolet", (int)cBoolet);
            PlayerPrefs.SetInt("cfuel", (int)cfuel);
            PlayerPrefs.SetInt("cntindxstart", cntindxstart+1);
        }

        

        coins = PlayerPrefs.GetInt("coins");
        gem = PlayerPrefs.GetInt("gems");
        chp = PlayerPrefs.GetInt("chp");
        cBoolet = PlayerPrefs.GetInt("cBoolet");
        cfuel = PlayerPrefs.GetInt("cfuel");

        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bonusrec.perk1 = PlayerPrefs.GetInt("perk1");
        testp = model.ids;
        txthp.text = chp.ToString();
        txtspeed.text = speed.ToString();
        txtBoolet.text = Boolet.ToString();
        txtfuel.text = fuel.ToString();
        coinsTXT.text = coins.ToString();
        gemTXT.text = gem.ToString();



        PlayerPrefs.SetInt("chp", (int)chp);
        PlayerPrefs.SetInt("cBoolet", (int)cBoolet);
        PlayerPrefs.SetInt("cfuel", (int)cfuel);
        // Debug.Log("Параметр Патроны перезаписан на" + (int)cBoolet);

        if (gameover.indexmuve == 1) {
            score += 1 * bonusrec.perk1;
            scoreTXT.text = score.ToString();
            scoreGOTXT.text = score.ToString();
        }
        bonusrec.perk3 = PlayerPrefs.GetInt("perk3");
        if (bonusrec.perk3 == 2) 
        {
            shotboton.SetActive(true);
        } else shotboton.SetActive(false);



        if (score > scorerecord)
        {
            scorerecord = score;
            PlayerPrefs.SetString("score", scorerecord.ToString());
            

        }
        scorerecordtxt.text = PlayerPrefs.GetString("score");
        str = PlayerPrefs.GetString("score");

        scorerecord = Int32.Parse(str);


        //PlayerPrefs.SetInt("cntindxstart",0);
        somolet.transform.Translate(new Vector3(1f, 0, 0) * speed * spcontrol * Time.deltaTime);
        //fuel-=Time.deltaTime;
        if (fuel <= 0f) 
        {
            spcontrol = 0;
        }

        if (model.ids == 1) 
        {
            modelsamoleta1.SetActive(true);
            modelsamoleta2.SetActive(false);
            modelsamoleta3.SetActive(false);
            modelsamoleta4.SetActive(false);
        }
        if (model.ids == 2)
        {
            modelsamoleta1.SetActive(false);
            modelsamoleta2.SetActive(true);
            modelsamoleta3.SetActive(false);
            modelsamoleta4.SetActive(false);
        }
        if (model.ids == 3)
        {
            modelsamoleta1.SetActive(false);
            modelsamoleta2.SetActive(false);
            modelsamoleta3.SetActive(true);
            modelsamoleta4.SetActive(false);
        }
        if (model.ids == 4)
        {
            modelsamoleta1.SetActive(false);
            modelsamoleta2.SetActive(false);
            modelsamoleta3.SetActive(false);
            modelsamoleta4.SetActive(true);
        }









    }

    
}
