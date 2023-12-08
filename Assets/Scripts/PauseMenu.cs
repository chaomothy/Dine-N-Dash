using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public bool isPaused;

    public GameObject pauseMenu;
    
    void Update()
    {
    
        if(Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
        
            PauseGame();

        }

    }    

    public void PauseGame()
    {
    
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }

    public void ResumeGame()
    {
    
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

    }

    public void ReturnToMenu()
    {
    
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        isPaused = false;

    }

}
