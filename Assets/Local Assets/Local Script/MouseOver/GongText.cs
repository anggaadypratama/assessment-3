using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GongText : MonoBehaviour
{

    public GameObject gongText;
    public GameObject Character;
    private float distance;
    public float objectDistance;

    private void Update() {
        distance = Vector3.Distance(Character.transform.position, gongText.transform.position);

    }

    public void Start() => gongText.SetActive(false);
    public void OnMouseExit() => gongText.SetActive(false);
    
    public void OnMouseOver() {
        if(distance < objectDistance){
            gongText.SetActive(true);
        }else{
            gongText.SetActive(false);

        }
    }

}
