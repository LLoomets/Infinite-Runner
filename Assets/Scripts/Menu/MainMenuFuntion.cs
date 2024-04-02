using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFuntion : MonoBehaviour
{

    // PlayGame - mängu käivitamine nupp
    public void PlayGame() 
    {
        SceneManager.LoadScene(1);
    }

    // QuitGame - mängu lõpetamise nupp
    public void QuitGame() 
    {
        // kontrollib kas mäng käib
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
