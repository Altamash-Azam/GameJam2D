using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    int score = 0;

    private void Update() {
        showScore();
        EndGame();
    }

    private void EndGame()
    {
        if(score >=5){
            SceneManager.LoadSceneAsync("End Game Menu");
        }
    }

    public void showScore(){
        scoreText.text = "SCORE:" + score;
    }

    public void updateScore(int number){
        score += number;
    }

}
