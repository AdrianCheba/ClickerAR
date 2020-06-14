using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shopping : MonoBehaviour
{
    public Button btnRatusz;
    public Button btnChata;
    public Button btnStajnia;
    public Button btnMagazyn;
    public Button btnDomSzlachty;
    public Text txtRatusz;
    public Text txtChata;
    public Text txtMagazyn;
    public Text txtStajnia;
    public Text txtDomSzlachty;
    public GameObject chata;
    public GameObject magazyn;
    public GameObject domSzlachty;
    public GameObject stajnia;

    GameObject ratusz;
    Main main;

    float zegar = 1;
    int punkty = 1;
    int RLVL = 1;
    int Rflaga = 100;
    int CLVL = 0;
    int Cflaga = 25;
    int MLVL = 0;
    int Mflaga = 125;
    int SLVL = 0;
    int Sflaga = 525;   
    int DLVL = 0;
    int Dflaga = 1025;

    void Start()
    {
        btnRatusz = btnRatusz.GetComponent<Button>();
        btnChata = btnChata.GetComponent<Button>();
        btnStajnia = btnStajnia.GetComponent<Button>();
        btnMagazyn = btnMagazyn.GetComponent<Button>();
        btnDomSzlachty = btnDomSzlachty.GetComponent<Button>();
        txtRatusz = txtRatusz.GetComponent<Text>();
        txtChata = txtChata.GetComponent<Text>();
        txtStajnia = txtStajnia.GetComponent<Text>();
        txtMagazyn = txtMagazyn.GetComponent<Text>();
        txtDomSzlachty = txtDomSzlachty.GetComponent<Text>();
        ratusz = GameObject.Find("ratusz");
        chata = GameObject.Find("chata");
        magazyn = GameObject.Find("magazyn");
        domSzlachty = GameObject.Find("domSzlachty");
        stajnia = GameObject.Find("stajnia");
        main = ratusz.GetComponent<Main>();

        btnStajnia.interactable = false;
        btnMagazyn.interactable = false;
        btnDomSzlachty.interactable = false;

    }


    void FixedUpdate()
    {
        zegar -= Time.fixedDeltaTime;
        if (zegar < 0)
        {
            main.licznik += punkty + CLVL + (SLVL * 5) + (MLVL * 10) + (DLVL * 25);
            zegar = 1;
        }

        txtRatusz.text = "Ratusz LVL: " + RLVL + Environment.NewLine + Environment.NewLine + "Ulepszenie:  " + Rflaga;
        
        txtChata.text = "Chata LVL: " + CLVL + Environment.NewLine + Environment.NewLine + "Ulepszenie:  " + Cflaga; 
        
        txtMagazyn.text = "Magazyn LVL: " + MLVL + Environment.NewLine + Environment.NewLine + "Ulepszenie:  " + Mflaga;

        txtStajnia.text = "Stajnia LVL: " + SLVL + Environment.NewLine + Environment.NewLine + "Ulepszenie:  " + Sflaga;

        txtDomSzlachty.text = "Dom Szlachty LVL: " + DLVL + Environment.NewLine + Environment.NewLine + "Ulepszenie:  " + Dflaga;
    }

    public void UpgradeRatusz()
    {
        if(main.licznik >= 100 && Rflaga == 100)
        {
            RLVL = 2;
            punkty = 2;
            btnStajnia.interactable = true;
            main.licznik -= 100;
            Rflaga = 500;
        } 
        else if(main.licznik >= 500 && Rflaga == 500)
        {
            RLVL = 3;
            punkty = 16;
            btnMagazyn.interactable = true;
            main.licznik -= 500;
            Rflaga = 2500;
        }     
        else if(main.licznik >= 2500 && Rflaga == 2500)
        {
            RLVL = 4;
            punkty = 64;
            btnDomSzlachty.interactable = true;
            main.licznik -= 2500;
            Rflaga = 3;
        }
    }

    public void UpgradeChata()
    {
        if(main.licznik >= Cflaga)
        {
            main.licznik -= Cflaga;
            CLVL += 1;
            Cflaga += 25;
            chata.SetActive(isActiveAndEnabled);
        }
    }

    public void UpgradeMagazyn()
    {
        if (main.licznik >= Mflaga)
        {
            main.licznik -= Mflaga;
            MLVL += 1;
            Mflaga += 125;
            magazyn.SetActive(isActiveAndEnabled);
        }
    }

    public void UpgradeStajnia()
    {
        if(main.licznik >= Sflaga)
        {
            main.licznik -= Sflaga;
            SLVL += 1;
            Sflaga += 525;
            stajnia.SetActive(isActiveAndEnabled);
        }
    }

    public void UpgradeDom()
    {
        if (main.licznik >= Dflaga)
        {
            main.licznik -= Dflaga;
            DLVL += 1;
            Dflaga += 1025;
            domSzlachty.SetActive(isActiveAndEnabled);
        }
    }
}
