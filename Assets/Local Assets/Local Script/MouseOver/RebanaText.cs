using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RebanaText : MonoBehaviour
{

    public GameObject rebanaText;
    public GameObject Character;
    private float distance;
    public float objectDistance;

    private void Update() {
        distance = Vector3.Distance(Character.transform.position, rebanaText.transform.position);

    }

    public void Start() => rebanaText.SetActive(false);
    public void OnMouseExit() => rebanaText.SetActive(false);
    
    public void OnMouseOver() {
        if(distance < objectDistance){
            rebanaText.SetActive(true);
        }else{
            rebanaText.SetActive(false);

        }
    }

}
