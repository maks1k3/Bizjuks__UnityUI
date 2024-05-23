using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursorsUzAttela : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource skanasAvots;
    public AudioClip skanaKoAtskanot;

    public void uzbiditUzAttela()
    {
        skanasAvots.PlayOneShot(skanaKoAtskanot);
    }
    public void kursosrsNoietNoAttela()
    {
        skanasAvots.Stop();
    }
}
