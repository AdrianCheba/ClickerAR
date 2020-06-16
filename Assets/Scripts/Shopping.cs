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
    public GameObject Clvl2;
    public GameObject Clvl3;
    public GameObject Mlvl2;
    public GameObject Mlvl3;  
    public GameObject Slvl2;
    public GameObject Slvl3; 
    public GameObject Dlvl2;
    public GameObject Dlvl3;

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
        Clvl2 = GameObject.Find("Clvl2");
        Clvl3 = GameObject.Find("Clvl3");
        Mlvl2 = GameObject.Find("Mlvl2");
        Mlvl3 = GameObject.Find("Mlvl3");
        Slvl2 = GameObject.Find("Slvl2");
        Slvl3 = GameObject.Find("Slvl3");  
        Dlvl2 = GameObject.Find("Dlvl2");
        Dlvl3 = GameObject.Find("Dlvl3");
        main = ratusz.GetComponent<Main>();


        btnStajnia.interactable = false;
        btnMagazyn.interactable = false;
        btnDomSzlachty.interactable = false;
        Clvl2.SetActive(false);
        Clvl3.SetActive(false);
        Mlvl2.SetActive(false);
        Mlvl3.SetActive(false);
        Slvl2.SetActive(false);
        Slvl3.SetActive(false);
        Dlvl2.SetActive(false);
        Dlvl3.SetActive(false);
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
            Rflaga = 7500;
        } 
        else if(main.licznik >= 7500 && Rflaga >= 7500)
        {
            RLVL += 1;
            punkty = 25*RLVL;
            btnDomSzlachty.interactable = true;
            main.licznik -= Rflaga;
            Rflaga += (Rflaga/2);
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

            if(CLVL == 2)
            {
                Clvl2.SetActive(true);
            }
            else if (CLVL == 3)
            {
                Clvl3.SetActive(true);
            }
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

            if (MLVL == 2)
            {
                Mlvl2.SetActive(true);
            }
            else if (MLVL == 3)
            {
                Mlvl3.SetActive(true);
            }
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

            if (SLVL == 2)
            {
                Slvl2.SetActive(true);
            }
            else if (SLVL == 3)
            {
                Slvl3.SetActive(true);
            }
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

            if (DLVL == 2)
            {
                Dlvl2.SetActive(true);
            }
            else if (DLVL == 3)
            {
                Dlvl3.SetActive(true);
            }
        }
    }
}
