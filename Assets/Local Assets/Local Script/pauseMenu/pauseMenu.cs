using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class pauseMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject crossHair;

    public static bool gamePause = false;

    void Start()
    {
        menu.SetActive(false);
        crossHair.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            menu.SetActive(!menu.activeSelf);
            crossHair.SetActive(!crossHair.activeSelf);


            if(gamePause){
                Time.timeScale = 1f;
                gamePause = false;
                Cursor.lockState = CursorLockMode.None;
            }else{
                Time.timeScale = 0f;
                gamePause = true;
                Cursor.lockState = CursorLockMode.Locked;
            }

        }

        if(menu.activeSelf){
            if(Input.GetKeyDown(KeyCode.Q)){
                closeGame();
            }else if(Input.GetKeyDown(KeyCode.M)){
                goToMainMenu();
            }
        }
    }

    void closeGame() => Application.Quit();
    void goToMainMenu() => SceneManager.LoadScene("menu");
}