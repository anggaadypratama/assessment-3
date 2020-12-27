using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{

    public Image darkFade;
    // Start is called before the first frame update
    void Start()
    {
        darkFade.canvasRenderer.SetAlpha(1.0f);
        fadeIn();
    }

    void fadeIn() =>  darkFade.CrossFadeAlpha(0,2,false);
}
