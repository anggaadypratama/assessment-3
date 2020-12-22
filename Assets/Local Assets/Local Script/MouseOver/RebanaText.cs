using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RebanaText : MonoBehaviour
{

    public GameObject rebanaText;
    // Start is called before the first frame update
    public void Start()
    {
        rebanaText.SetActive(false);
    }

    public void OnMouseOver(){
        rebanaText.SetActive(true);
    }

    public void OnMouseExit(){
        rebanaText.SetActive(false);
    }

}
