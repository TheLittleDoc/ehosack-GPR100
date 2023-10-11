using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreValue;

    private int score = 0;

    public void AddScore()
    {
        score++;
        scoreValue.text = score.ToString();
    }
}
