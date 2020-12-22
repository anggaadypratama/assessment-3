using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TifaText : MonoBehaviour
{

    public GameObject tifaText;
    // Start is called before the first frame update
    public void Start()
    {
        tifaText.SetActive(false);
    }

    public void OnMouseOver(){
        tifaText.SetActive(true);
    }

    public void OnMouseExit(){
        tifaText.SetActive(false);
    }

}
