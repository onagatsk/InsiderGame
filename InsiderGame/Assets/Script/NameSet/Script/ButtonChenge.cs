using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonChenge : MonoBehaviour
{

    public GameObject NameManager;
    public int ButtonNameCount;
    private NameInputField NameSetScript;

    private Text ButtonText;

    private int TrueCount = 0;//charjudge関数のカウントUPでしか使ってないやつ

    public bool fildflg;
    // Use this for initialization
    void Start()
    {
        ButtonText = this.GetComponent<Text>();
        NameSetScript = NameManager.GetComponent<NameInputField>();
    }

    // Update is called once per frame
    void Update()
    {
        charjudge();
        for (int i = 0; i < NameSetScript.Provisional; i++)
        {
            for (int k = 0; k < NameSetScript.Provisional; k++)
            {
                if (i != k)
                {
                    if (NameSetScript.PlayerName[i] == NameSetScript.inputfield[k].text)
                    {
                        fildflg = false;
                    }
                }
                else
                {
                    if (NameSetScript.PlayerName[i] == NameSetScript.inputfield[i].text)
                    {
                        fildflg = true;
                    }
                    else
                    {
                        fildflg = false;
                    }
                }
            } 
            if (!fildflg) break;
        }
    }

    void charjudge()
    {
        for (int i = 0; i < NameSetScript.Provisional; i++)
        {
            if (NameSetScript.PlayerName[i] != NameSetScript.InputName[i] || !fildflg)
            {
                ButtonText.text = "決定";
            }
            else
            {
                TrueCount++;
            }
        }
        if (TrueCount == NameSetScript.Provisional)
        {
            ButtonText.text = "次へ";
            TrueCount = 0;
        }

    }
}
