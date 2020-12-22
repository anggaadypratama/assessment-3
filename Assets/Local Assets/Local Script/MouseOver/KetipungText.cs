using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KetipungText : MonoBehaviour
{

    public GameObject ketipungText;
    // Start is called before the first frame update
    public void Start()
    {
        ketipungText.SetActive(false);
    }

    public void OnMouseOver(){
        Console.WriteLine(true);
        ketipungText.SetActive(true);
    }

    public void OnMouseExit(){
        Console.WriteLine(false);
        ketipungText.SetActive(false);
    }

}
