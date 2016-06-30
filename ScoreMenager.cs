using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreMenager : MonoBehaviour {


    public int highScore;
    public string LevelName;
    public Text Score;
    
    private string highScoreKey;

    void Start()
    {
        highScoreKey = "HighScore" + LevelName;
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        Score.text = " " + highScore;
    }

    void Update()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        Score.text = " " + highScore;    }

    public void DelateScore(string highScore)
    {
        PlayerPrefs.SetInt(highScoreKey, 0);
        PlayerPrefs.Save();

    }
}
