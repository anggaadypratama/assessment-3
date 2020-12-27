using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeDelay : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 1f;

    public GameObject image;
    private float timeElapsed;

    private void Start(){
        image.SetActive(true);
    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if(timeElapsed > delayBeforeLoading){
            image.SetActive(false);
            print("muncul");
        }
    }
}
