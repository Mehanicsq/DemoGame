using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public SkillManager[] skillcollerctor;

    


    public int bonus;
    public int x2gold;
    public int shot;
    public int dublehp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (skillcollerctor[0].indexskill == 1) 
        {
            bonus = 2;
        }
        if (skillcollerctor[1].indexskill == 2)
        {
            x2gold = 2;
        }
        if (skillcollerctor[2].indexskill == 3)
        {
            shot = 2;
        }
        if (skillcollerctor[3].indexskill == 4)
        {
            dublehp = 2;
        }
    }

}
