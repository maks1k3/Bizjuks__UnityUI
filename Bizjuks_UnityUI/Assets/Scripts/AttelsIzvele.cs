using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttelsIzvele : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaideris;
    public GameObject slaideris2;

    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        }
        if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }
       
    }
    public void mainitGarumu()
    {
        float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
        float garums = pasreizejaVertiba * 2;
        mainigaisAttels.transform.localScale = new Vector3(garums, garums, 1);
    }
    public void mainitPlatumu()
    {
        float pasreizejaVertiba = slaideris2.GetComponent<Slider>().value;
        float platums = pasreizejaVertiba * 4;
        mainigaisAttels.transform.localScale = new Vector3(platums, 1, 1);
    }
}
