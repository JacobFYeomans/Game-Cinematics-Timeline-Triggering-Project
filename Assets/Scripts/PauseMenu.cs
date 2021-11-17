using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public string loadScene;

    public GameObject pausedGameObject;
    public GameObject resumeGameObject;
    public GameObject restartGameObject;
    public GameObject quitGameObject;

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausedGameObject.SetActive(false);
        resumeGameObject.SetActive(false);
        restartGameObject.SetActive(false);
        quitGameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("main_menu");
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
        pausedGameObject.SetActive(false);
        resumeGameObject.SetActive(false);
        restartGameObject.SetActive(false);
        quitGameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}

