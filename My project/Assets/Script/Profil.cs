using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Profil : MonoBehaviour
{
    public TextMeshProUGUI txtProfilNameForm;
    public Text txtProfilNameGame;
    public InputField enterprofiltxt;
    public string profName;

    public void savetxt()
    {
        profName = txtProfilNameGame.text;
        PlayerPrefs.SetString("PlayerName", profName);
        
        showsavetxt();

    }
    public void showsavetxt()
    {
        txtProfilNameForm.text = profName;

    }

    // Update is called once per frame
    void Update()
    {
        profName = PlayerPrefs.GetString("PlayerName");
        showsavetxt();
    }
}
