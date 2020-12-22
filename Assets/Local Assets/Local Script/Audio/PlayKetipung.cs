using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayKetipung : MonoBehaviour
{
    public AudioSource audioKetipung;
    public AudioClip klikKetipung;

    public void ClickSound(){
        audioKetipung.PlayOneShot(klikKetipung);
    }
}
