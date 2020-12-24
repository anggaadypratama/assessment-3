using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject apakahAktif;

    public void Start(){
        apakahAktif.SetActive(false);
    }

    public void Aktif(){
        apakahAktif.SetActive(true);
    }

    public void Mati(){
        apakahAktif.SetActive(false);
    }
}
