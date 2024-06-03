using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    int score = 0;

    private void Update() {
        showScore();
    }
    public void showScore(){
        scoreText.text = "SCORE:" + score;
    }

    public void updateScore(int number){
        score += number;
    }

}
