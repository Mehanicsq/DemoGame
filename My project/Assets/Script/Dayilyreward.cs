using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dayilyreward : MonoBehaviour
{
    public int indexmoney;

    public int goldcena;
    public TextMeshProUGUI txtlenthgold;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (indexmoney == 1) 
        {
            txtlenthgold.text = goldcena.ToString();
        }  
    }
}
