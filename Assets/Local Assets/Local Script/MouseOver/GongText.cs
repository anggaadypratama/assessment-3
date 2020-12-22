using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GongText : MonoBehaviour
{

    public GameObject gongText;
    // Start is called before the first frame update
    public void Start()
    {
        gongText.SetActive(false);
    }

    public void OnMouseOver(){
        gongText.SetActive(true);
    }

    public void OnMouseExit(){
        gongText.SetActive(false);
    }

}
