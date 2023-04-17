using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{

    

    public int indexskill;

    public Image img;

    public Sprite[] spr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


        if (indexskill == 1) 
        {
            img.sprite = spr[0];
        }
        if (indexskill == 2)
        {
            img.sprite = spr[1];
        }
        if (indexskill == 3)
        {
            img.sprite = spr[2];
        }
        if (indexskill == 4)
        {
            img.sprite = spr[3];

        }
        if (indexskill == 5) 
        {
            img.sprite = spr[4];
        }
    }


}
