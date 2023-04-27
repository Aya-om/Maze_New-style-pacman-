using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject optionsMenu;
    public GameObject enableMusic;
    public GameObject disableMusic;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        startMenu.SetActive(false);
    }
    public void ShowOptions()
    {
        startMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void ExitOptions()
    {
        Time.timeScale = 1;
        //startMenu.SetActive(false);
        optionsMenu.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
