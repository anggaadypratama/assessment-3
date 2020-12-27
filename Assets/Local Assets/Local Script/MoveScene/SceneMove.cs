using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMove : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 9f;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;

    public Color color = Color.black;

    // Update is called once per frame
    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if(timeElapsed > delayBeforeLoading){
            Initiate.Fade(sceneNameToLoad,color,2f);
        }
    }
}
