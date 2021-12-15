using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class landinglvl2 : MonoBehaviour
{
    public static int Score2;
    public Text scoreText2;
    public int Soft2 = 0;
    public int Hard2 = 1;
    public GameObject rocket;
    
    public void Awake()
    {
        Score2 = landinglvl2.Score2;
        //scoreText2.text = Score2.ToString();
        //DontDestroyOnLoad(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Landing to planet");
            HardAddScore();
        }
    }

    public void Update()
    {
        if(Score2 >= 10)
        {
            YouWin();
        }
    }
    public void YouWin()
    {
        Debug.Log("here");
        //ScoreText2.text = "You Win!";
        //Time.timeScale = 0f;
    }
    
    public void HardAddScore()
    {
        if (Hard2 == 1)
        {
            Score2++;
            //ScoreText.text = Score.ToString();
            Debug.Log(Score2);
            Debug.Log("addhard");
        }
        //else
        //{
            //Score = Score;
            //ScoreText.text = "You are Wrong!";
            //Time.timeScale = 0f;
         //   Debug.Log("You are wrong!");
        //}
    }
    
}
