using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{

    public GameObject Panel;
    public bool isActive = true;


    public void Start()
    {
        Panel.SetActive(!isActive);
    }

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(isActive);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Panel.SetActive(!isActive);
        }
    }

}