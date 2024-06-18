using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreManager scoreManager;
    void Start()
    {
        scoreManager.AddScore(new Score("khaled", 61));
        scoreManager.AddScore(new Score("ahmed", 4));
        scoreManager.AddScore(new Score("eahab", 65));
        scoreManager.AddScore(new Score("osama", 66));
        scoreManager.AddScore(new Score("hamdy", 62));

        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }
}

