using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toogle : MonoBehaviour
{
    public GameObject melnsKepons;
    public GameObject zilsKepons;
    public GameObject peleksKepons;
    public GameObject brilles;
    public GameObject brilles1;
    public GameObject brilles2;
    public GameObject krekls;
    public GameObject krekls1;
    public GameObject krekls2;

    public void keponuAtelosana(bool vertiba)
    {
        melnsKepons.SetActive(vertiba);
        zilsKepons.SetActive(vertiba);
        peleksKepons.SetActive(vertiba);
    }
    public void brilluAtelosana(bool vertiba)
    {
        brilles.SetActive(vertiba);
        brilles1.SetActive(vertiba);
        brilles2.SetActive(vertiba);
    }
    public void krekluAtelosana(bool vertiba)
    {
        krekls.SetActive(vertiba);
        krekls1.SetActive(vertiba);
        krekls2.SetActive(vertiba);
    }
}
