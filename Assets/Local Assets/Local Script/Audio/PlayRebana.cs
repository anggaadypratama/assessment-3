using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRebana : MonoBehaviour
{

    public AudioSource audioRebana;
    public AudioClip klikRebana;

    public void ClickSound(){
        audioRebana.PlayOneShot(klikRebana);
    }
}
