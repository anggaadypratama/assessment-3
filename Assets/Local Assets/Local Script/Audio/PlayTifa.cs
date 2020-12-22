using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTifa : MonoBehaviour
{

    public AudioSource audioTifa;
    public AudioClip klikTifa;

    public void ClickSound(){
        audioTifa.PlayOneShot(klikTifa);
    }
}
