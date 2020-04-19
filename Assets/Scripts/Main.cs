using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject chata;
    public GameObject magazyn;
    public GameObject domSzlachty;
    public GameObject stajnia;
    public Text txt;

    int licznik = 0;

    void Start()
    {
        chata = GameObject.Find("chata");
        magazyn = GameObject.Find("magazyn");
        domSzlachty = GameObject.Find("domSzlachty");
        stajnia = GameObject.Find("stajnia");
        txt = txt.GetComponent<Text>();

        chata.SetActive(false);
        magazyn.SetActive(false);
        domSzlachty.SetActive(false);
        stajnia.SetActive(false);
    }


    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))
            {
                string hitTag = Hit.transform.tag;

                if(CompareTag("Gród"))
                {
                    licznik += 1;
                }
            }
        }

        txt.text = "Liczba punktów " + licznik;
    }
}
