using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPAused = false;

    [SerializeField] GameObject pauseMenuUi;
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject resumeButton;

    public static bool GameIsPaused = false;


    private void Start()
    {
        pauseMenuUi.SetActive(false);    
    }




    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
        
    }

    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        
    }

    

}
