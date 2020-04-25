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
    GameObject ratusz;
    Main main;
    float zegar = 1; 

    void Start()
    {
        btnRatusz = btnRatusz.GetComponent<Button>();
        btnChata = btnChata.GetComponent<Button>();
        btnStajnia = btnStajnia.GetComponent<Button>();
        btnMagazyn = btnMagazyn.GetComponent<Button>();
        btnDomSzlachty = btnDomSzlachty.GetComponent<Button>();
        ratusz = GameObject.Find("ratusz");
        main = ratusz.GetComponent<Main>();
    }


    void FixedUpdate()
    {
        zegar -= Time.fixedDeltaTime;
        if (zegar < 0)
        {
            main.licznik += 1;
            zegar = 1;
        }
    }


}
