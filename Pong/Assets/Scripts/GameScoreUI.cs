using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameScoreUI : MonoBehaviour
{
    int goalsPlayerOne;
    int goalsPlayerTwo;

    public TextMeshProUGUI scoreText;

   public void ResetScore()
    {
        goalsPlayerOne = 0;
        goalsPlayerTwo = 0;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = goalsPlayerOne + " : " + goalsPlayerTwo;
    }

    public void goalPlayerOne()
    {
        goalsPlayerOne++;
        UpdateScoreText();
    }
    public void goalPlayerTwo()
    {
        goalsPlayerTwo++;
        UpdateScoreText();
    }
}
