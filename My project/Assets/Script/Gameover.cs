using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour
{

    public Menu mg;
    public Menu gameover;

    public EnterFly bonusrec;

    public Collider collidercontrol;
    public float timectr;
    public int indexctr;




    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "boom")
        {
            bonusrec.perk4 = PlayerPrefs.GetInt("perk4");
            if (bonusrec.perk4 == 2)
            {
                indexctr = 1;
            }
            else timectr = 6;
            if (timectr > 5)
            {
                gameover.indexmuve = 0;
                mg.gameoverpanel.SetActive(true);
                mg.Gmenu.SetActive(false);
                mg.spctr.spcontrol = 0f;
                mg.SamoletPosControl.transform.position = new Vector3(-0.82f, 0.49f, 3.329192f);
                mg.SamoletPos.transform.position = new Vector3(-0.31f, 0.5f, -4.5f);
            }

        }


        if (other.tag == "boom1")
        {



            gameover.indexmuve = 0;
            mg.gameoverpanel.SetActive(true);
            mg.Gmenu.SetActive(false);
            mg.spctr.spcontrol = 0f;
            mg.SamoletPosControl.transform.position = new Vector3(-0.82f, 0.49f, 3.329192f);
            mg.SamoletPos.transform.position = new Vector3(-0.31f, 0.5f, -4.5f);

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (indexctr == 1) {
            timectr += Time.deltaTime;

        }
    }
}
