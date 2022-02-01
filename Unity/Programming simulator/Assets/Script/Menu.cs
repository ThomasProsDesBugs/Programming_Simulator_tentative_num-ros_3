using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour

{
   
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Retry()
    {
        Debug.Log("re");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
