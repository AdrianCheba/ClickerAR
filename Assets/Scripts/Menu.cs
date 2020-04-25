using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject btnSzalka1;
    public GameObject btnSzalka2;
    public Image menu;
    void Start()
    {
        btnSzalka1 = GameObject.Find("Rozwin");
        btnSzalka2 = GameObject.Find("Zwin");
        menu = menu.GetComponent<Image>();

        btnSzalka2.SetActive(false);
    }

    public void BTNSzczalka()
    {

         menu.transform.localPosition = new Vector3(menu.transform.localPosition.x + 500, menu.transform.localPosition.y, menu.transform.localPosition.z);
         btnSzalka1.SetActive(false);
         btnSzalka2.SetActive(true);

    }   
    public void BTNSzczalka2()
    {

         menu.transform.localPosition = new Vector3(menu.transform.localPosition.x - 500, menu.transform.localPosition.y, menu.transform.localPosition.z);
         btnSzalka2.SetActive(false);
         btnSzalka1.SetActive(true);

    }
}
