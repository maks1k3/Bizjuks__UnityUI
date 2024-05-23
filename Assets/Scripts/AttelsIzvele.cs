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
    public AudioSource skanasAvots;
    public AudioClip[] skanaKoAtskanot;
    public Text tekstsS;


    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
        {
            skanasAvots.clip = skanaKoAtskanot[0];
            skanasAvots.Play();
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
            tekstsS.text ="Lionels Messi dzimis 1987. gada 24. jūnijā, plaši zināms arī kā Leo, ir Argentīnas futbolists, kas spēlē uzbrucēja pozīcijā. Kopš 2023. gada jūlija pārstāv MLS klubu Maiami \"Inter\". Mesi bieži tiek dēvēts par pasaules labāko futbolistu, un nereti arī par visu laiku labāko.[3] Viņš ir ieguvis astoņas Zelta bumbas, un ir vienīgais futbolists vēsturē, kurš to paveicis četrus gadus pēc kārtas, kā arī sešas reizes ieguvis Zelta zābaku.";
        }
        if (skaitlis == 1)
        {
            skanasAvots.clip = skanaKoAtskanot[1];
            skanasAvots.Play();
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
            tekstsS.text ="Krištianu Ronaldu duš Santušs Aveiru  dzimis 1985. gada 5. februārī) ir portugāļu futbolists, spēlē uzbrucēja un pussarga pozīcijā, Portugāles izlases spēlētājs. Pašlaik pārstāv Saūda Arābijas klubu Al Nassr. Krištianu Ronaldu ir 2008. gada Zelta bumbas ieguvējs, 2013. un 2014. gada FIFA Zelta bumbas ieguvējs un 2016. un 2017. gada atjaunotās Zelta bumbas ieguvējs. Portugāles izlases sastāvā kļuva par 2016. gada Eiropas čempionu. Portugāles Futbola federācija atzinusi Krištianu Ronaldu par visu laiku labāko Portugāles futbolistu. Piecas reizes ir uzvarējis UEFA Čempionu līgā. 2021. gadā kļuva par vārtu guvumiem bagātāko spēlētāju valstsvienību futbolā (pašlaik 123 vārti); ir arī visvairāk izlases spēles nospēlējušais (200) futbolists Pasaules futbolā.";
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
