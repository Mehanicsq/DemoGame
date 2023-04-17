using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batata : MonoBehaviour
{
    public Buy prups1;
    public Buy prups2;
    public Buy prups3;
    public Buy prups4;

    public GameObject buyd1;
    public GameObject buyd2;
    public GameObject buyd3;
    public GameObject buyd4;


    public GameObject pokupka1;
    public GameObject pokupka2;
    public GameObject pokupka3;
    public GameObject pokupka4;


    public GameObject vibor1;
    public GameObject vibor2;
    public GameObject vibor3;
    public GameObject vibor4;




    public int idsammodel1;
    public int idsammodel2;
    public int idsammodel3;
    public int idsammodel4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       


        if (PlayerPrefs.GetInt("sm1") == idsammodel1)
        {
            buyd1.SetActive(false);
            pokupka1.SetActive(false);
            vibor1.SetActive(true);
            
        }
        if (PlayerPrefs.GetInt("sm2") == idsammodel2)
        {
            buyd2.SetActive(false);
            pokupka2.SetActive(false);
            vibor2.SetActive(true);
           
        }
        if (PlayerPrefs.GetInt("sm3") == idsammodel3)
        {
            buyd3.SetActive(false);
            pokupka3.SetActive(false);
            vibor3.SetActive(true);
            
        }
        if (PlayerPrefs.GetInt("sm4") == idsammodel4)
        {
            buyd4.SetActive(false);
            pokupka4.SetActive(false);
            vibor4.SetActive(true);
            
        }

    }
}
