using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{
    public void mainMenu(){
        SceneManager.LoadSceneAsync(0);
    }
    public void endGame(){
        Application.Quit();
    }
}
