using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KetipungText : MonoBehaviour
{

    public GameObject ketipungText;
    public GameObject Character;
    private float distance;
    public float objectDistance;

    private void Update() {
        distance = Vector3.Distance(Character.transform.position, ketipungText.transform.position);

    }

    public void Start() => ketipungText.SetActive(false);
    public void OnMouseExit() => ketipungText.SetActive(false);
    
    public void OnMouseOver() {
        if(distance < objectDistance){
            ketipungText.SetActive(true);
        }else{
            ketipungText.SetActive(false);

        }
    }

}
