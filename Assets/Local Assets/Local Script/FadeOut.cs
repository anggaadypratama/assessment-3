using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{

    public Image darkFade;
    public GameObject overlay;
    public string sceneName;
    // Start is called before the first frame update

    private void Start() {
        darkFade.canvasRenderer.SetAlpha(0.0f);

    }

    public void StartFadeOut(){
        StartCoroutine(fadeOut());
        overlay.SetActive(true);
    }


    IEnumerator fadeOut(){
        darkFade.CrossFadeAlpha(1,2,false);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
