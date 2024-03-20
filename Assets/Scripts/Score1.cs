using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score1 : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    public float timer = 0f;
    public float timerRate = 1f;

    public Text scoreDisplayDark;
    public Text scoreDisplayLight;

    public int nextLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * timerRate;

        if (timer >= 1f)
        {
            score++;
            scoreDisplayDark.text = "Score: " + score.ToString();
            scoreDisplayLight.text = "Score: " + score.ToString();
            timer = 0f;

            if (score > highScore)
            {
                highScore = score;
            }
        }
        if (score == 25)
        {
            EndLevel();
        }
    }

    public void EndLevel()
    {
        if (score >= 25)
        {
            Invoke("NextLevel", 1);
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}