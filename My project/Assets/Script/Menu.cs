using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class Menu : MonoBehaviour
{
    public Move spctr;



    public GameObject Profil;
    public GameObject Profilbkg;

    public GameObject menu;
    public GameObject Gmenu;
    public GameObject garage;
    public GameObject gameoverpanel;

    public GameObject SamoletPosControl;
    public GameObject SamoletPos;

    public GameObject profilopt;
    public GameObject imageprof;

    public GameObject dailyR;
    public GameObject daydailyR;


    public GameObject magazin;

    public int indexmuve;








    // Start is called before the first frame update
    void Start()
    {
       // HMSAdsKitManager.Instance.HideBannerAd();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Mplay() 
    {
        
        spctr.spcontrol = 1f;
        spctr.fuel = spctr.cfuel;
        spctr.hp = spctr.chp;
        spctr.Boolet = spctr.cBoolet;
        spctr.speed = spctr.cspeed;
        spctr.score = 0;
     


        Profil.SetActive(false);
        Profilbkg.SetActive(false);
        menu.SetActive(false);
        Gmenu.SetActive(true);


        indexmuve = 1;

        



    }
    public void Exit()
    {
        Profil.SetActive(true);
        Profilbkg.SetActive(true);
        menu.SetActive(true);
        Gmenu.SetActive(false);
        spctr.spcontrol = 0f;
        SamoletPosControl.transform.position = new Vector3(-0.52f, 0.49f, 3.329192f);
        SamoletPos.transform.position = new Vector3(-0.31f, 0.5f, -7.7f);
        SceneManager.LoadScene(0);
        indexmuve = 0;

    }
    public void Garage()
    {
        menu.SetActive(false);
        
        garage.SetActive(true);
        
    }
    public void exitGarage()
    {
        menu.SetActive(true);
      
        garage.SetActive(false);

    }
    public void gameover()
    {
        gameoverpanel.SetActive(false);
        menu.SetActive(true);
        Profil.SetActive(true);
        Profilbkg.SetActive(true);
        SceneManager.LoadScene(0);

    }
    public void profiloptions()
    {
        profilopt.SetActive(true);
        
    }

    public void exitprofiloptions()
    {
        profilopt.SetActive(false);

    }

    public void dailyopsop() 
    {
        dailyR.SetActive(true);
    }
    public void dailyopsext()
    {
        dailyR.SetActive(false);
    }

    public void daydailyopsop()
    {
        daydailyR.SetActive(true);
    }
    public void daydailyopsext()
    {
        daydailyR.SetActive(false);
    }

    public void Magazinopen()
    {
        magazin.SetActive(true);
    }
    public void MagazinExit()
    {
        magazin.SetActive(false);
    }

    public void Signin() 
    {
        

    }

}
