using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{
    public GameObject Character;
    private float distanceTifa;
    private float distanceKetipung;
    private float distanceGong;
    private float distanceRebana;

    public float objectDistance = 6;

    public GameObject popUpTifa;
    public GameObject popUpGong;
    public GameObject popUpRebana;
    public GameObject popUpKetipung;

    public GameObject tifaBox;
    public GameObject gongBox;
    public GameObject rebanaBox;
    public GameObject ketipungBox;

    private bool isTifa = false;
    private bool isGong = false;
    private bool isRebana = false;
    private bool isKetipung = false;

    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
        popUpTifa.SetActive(isTifa);
        popUpGong.SetActive(isGong);
        popUpRebana.SetActive(isRebana);
        popUpKetipung.SetActive(isKetipung);
    }

    // Update is called once per frame
    private void Update()
    {
        distanceTifa = Vector3.Distance(Character.transform.position, tifaBox.transform.position);
        distanceRebana = Vector3.Distance(Character.transform.position, rebanaBox.transform.position);
        distanceGong = Vector3.Distance(Character.transform.position,   gongBox.transform.position);
        distanceKetipung = Vector3.Distance(Character.transform.position, ketipungBox.transform.position);
        
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100.0f)){
                if(hit.transform != null){
                    if(hit.transform.gameObject == tifaBox){
                        if(distanceTifa < objectDistance){
                            popUpTifa.SetActive(!isTifa);
                            Time.timeScale = 0f;
                        }
                    }else if(hit.transform.gameObject == gongBox){
                        if(distanceGong < objectDistance){
                            popUpGong.SetActive(!isGong);
                            Time.timeScale = 0f;
                        }
                    }else if(hit.transform.gameObject == rebanaBox){
                        if(distanceRebana < objectDistance){
                            popUpRebana.SetActive(!isRebana);
                            Time.timeScale = 0f;
                        }
                    }else if(hit.transform.gameObject == ketipungBox){
                        if(distanceKetipung < objectDistance){
                            popUpKetipung.SetActive(!isKetipung);
                            Time.timeScale = 0f;
                        }
                    }
                }
            }
        }else if(Input.GetKeyDown(KeyCode.C)){
            Time.timeScale = 1f;
            popUpTifa.SetActive(isTifa);
            popUpGong.SetActive(isGong);
            popUpRebana.SetActive(isRebana);
            popUpKetipung.SetActive(isKetipung);
        }
    }

    // private void PrintName(GameObject go){
    //     print(go.name);
    // }

}
