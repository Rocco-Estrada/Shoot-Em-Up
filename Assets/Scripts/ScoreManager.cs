using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ScoreManager : MonoBehaviour
{

    [SerializeField] private Text scoreText;
    [SerializeField] private Text hiScoreText;


    private static int score = 0;
    private static int hiScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        hiScoreText = GetComponent<Text>();
        scoreText.text = score.ToString("D4");
        hiScoreText.text = hiScore.ToString("D4");

    }

    private void Update()
    {
        scoreText.text = score.ToString("D4");
        hiScore = score;
        hiScoreText.text = hiScore.ToString("D4");
        Restart();
    }

    public void Update(string name)
    {
        if (name == "Enemy A(Clone)") { score += 10; }
        else if (name == "Enemy B(Clone)") { score += 20; }
        else if (name == "Enemy C(Clone)") { score += 30; }
        else if (name == "Enemy D") { score += 40; }
    }

    void Restart()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            hiScore = 0;
            score = 0;
            SceneManager.LoadScene("Space Invaders");
        }
    }
}
