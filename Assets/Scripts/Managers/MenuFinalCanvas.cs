using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuFinalCanvas : MonoBehaviour
{

    public Button backButton;
    void Start()
    {
        backButton.Select();
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void ExitGameFinal()
    {
        Application.Quit();
    }


    public void ReturnTown()
    {

        Time.timeScale = 1f;
        Global.PlayerScript = false;
        Global.nivel = 4;
        PlayerPrefs.SetInt("LevelMax",Global.nivel);
        SceneManager.LoadScene(Global.nivel);
    }

        public void ReturnMenu()
    {
        Time.timeScale = 1f;
        Global.PlayerScript = false;
        Global.nivel = 4;
        PlayerPrefs.SetInt("LevelMax",Global.nivel);
        SceneManager.LoadScene(0);
    }
}
