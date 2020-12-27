using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TifaText : MonoBehaviour
{

    public GameObject tifaText;
    public GameObject Character;
    private float distance;
    public float objectDistance;

    private void Update() {
        distance = Vector3.Distance(Character.transform.position, tifaText.transform.position);

    }

    public void Start() => tifaText.SetActive(false);
    public void OnMouseExit() => tifaText.SetActive(false);
    
    public void OnMouseOver() {
        if(distance < objectDistance){
            tifaText.SetActive(true);
        }else{
            tifaText.SetActive(false);

        }
    }

}
