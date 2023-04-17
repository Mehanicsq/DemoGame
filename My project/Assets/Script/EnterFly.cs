using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterFly : MonoBehaviour
{

    public Skill[] skillplane;

    public int index;

    public GameObject[] noomerSamoleta;

    public GameObject[] galochka;


    public int ids;

    public int perk1;
    public int perk2;
    public int perk3;
    public int perk4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (index == 0) 
        {
            noomerSamoleta[0].SetActive(true);
            noomerSamoleta[1].SetActive(false);
            noomerSamoleta[2].SetActive(false);
            noomerSamoleta[3].SetActive(false);
        }
        if (index == 1)
        {
            noomerSamoleta[0].SetActive(false);
            noomerSamoleta[1].SetActive(true);
            noomerSamoleta[2].SetActive(false);
            noomerSamoleta[3].SetActive(false);
        }
        if (index == 2)
        {
            noomerSamoleta[0].SetActive(false);
            noomerSamoleta[1].SetActive(false);
            noomerSamoleta[2].SetActive(true);
            noomerSamoleta[3].SetActive(false);
        }
        if (index == 3)
        {
            noomerSamoleta[0].SetActive(false);
            noomerSamoleta[2].SetActive(false);
            noomerSamoleta[2].SetActive(false);
            noomerSamoleta[3].SetActive(true);
        }
        if (index < 0)
        {
            index += 1;
        }
        if (index > 3)
        {
            index -= 1;
        }
        ids = PlayerPrefs.GetInt("idsam");

        if (ids == 1)
        {
            galochka[0].SetActive(true);
            galochka[1].SetActive(false);
            galochka[2].SetActive(false);
            galochka[3].SetActive(false);
            perk1 = skillplane[0].bonus;
            perk2 = skillplane[0].x2gold;
            perk3 = skillplane[0].bonus;
            perk4 = skillplane[0].dublehp;
            PlayerPrefs.SetInt("perk1", 1);
            PlayerPrefs.SetInt("perk2", 1);
            PlayerPrefs.SetInt("perk3", 1);
            PlayerPrefs.SetInt("perk4", 1);



        }
        if (ids == 2)
        {
            galochka[0].SetActive(false);
            galochka[1].SetActive(true);
            galochka[2].SetActive(false);
            galochka[3].SetActive(false);
            perk1 = skillplane[1].bonus;
            perk2 = skillplane[1].x2gold;
            perk3 = skillplane[1].bonus;
            perk4 = skillplane[1].dublehp;
            PlayerPrefs.SetInt("perk1", 2);
            PlayerPrefs.SetInt("perk2", 1);
            PlayerPrefs.SetInt("perk3", 1);
            PlayerPrefs.SetInt("perk4", 1);

        }
        if (ids == 3)
        {
            galochka[0].SetActive(false);
            galochka[1].SetActive(false);
            galochka[2].SetActive(true);
            galochka[3].SetActive(false);
            perk1 = skillplane[2].bonus;
            perk2 = skillplane[2].x2gold;
            perk3 = skillplane[2].bonus;
            perk4 = skillplane[2].dublehp;
            PlayerPrefs.SetInt("perk1", 1);
            PlayerPrefs.SetInt("perk2", 2);
            PlayerPrefs.SetInt("perk3", 1);
            PlayerPrefs.SetInt("perk4", 1);
        }
        if (ids == 4)
        {
            galochka[0].SetActive(false);
            galochka[1].SetActive(false);
            galochka[2].SetActive(false);
            galochka[3].SetActive(true);
            perk1 = skillplane[3].bonus;
            perk2 = skillplane[3].x2gold;
            perk3 = skillplane[3].bonus;
            perk4 = skillplane[3].dublehp;
            PlayerPrefs.SetInt("perk1", 2);
            PlayerPrefs.SetInt("perk2", 2);
            PlayerPrefs.SetInt("perk3", 2);
            PlayerPrefs.SetInt("perk4", 2);

        }


    }


    public void next()
    {
        index += 1;
    }
    public void back()
    {
        index -= 1;
    }


    public void enterfly ()
    {


        if (index == 0)
        {
            galochka[0].SetActive(true);
            galochka[1].SetActive(false);
            galochka[2].SetActive(false);
            galochka[3].SetActive(false);
            ids = 1;
        }
        if (index == 1)
        {
            galochka[0].SetActive(false);
            galochka[1].SetActive(true);
            galochka[2].SetActive(false);
            galochka[3].SetActive(false);
            ids = 2;
        }
        if (index == 2)
        {
            galochka[0].SetActive(false);
            galochka[1].SetActive(false);
            galochka[2].SetActive(true);
            galochka[3].SetActive(false);
            ids = 3;
        }
        if (index == 3)
        {
            galochka[0].SetActive(false);
            galochka[1].SetActive(false);
            galochka[2].SetActive(false);
            galochka[3].SetActive(true);
            ids = 4;
        }
        PlayerPrefs.SetInt("idsam", ids);

    }



}
