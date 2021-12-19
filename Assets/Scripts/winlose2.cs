using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Assertions.Must;
using UnityEngine.EventSystems;

public class winlose2 : MonoBehaviour
{
    public static int Score;
    //public Text ScoreText;
    public Text Message;
    public int Soft;
    public int Hard;
    public bool isRacing;
    public float currentTime;
    public float endTime;
    public static float Stars;
    private Text txt;
    public bool star1ImgOn;
    public Image star1;
    public bool star2ImgOn;
    public Image star2;
    public bool star3ImgOn;
    public Image star3;
    public Transform Image_Changer2;
    public float MeanStars;
    public static int countingwords;
    private Text Words;
    public Text number;
    public Text annoucement;
    public RocketMovLvl2 Rmv2;
    public int c;
    public int d;
    public static int numberofreload2;

    public void Awake()
    {
        
        Score = winlose2.Score;
        //ScoreText.text = Score.ToString();
        countingwords = winlose2.countingwords;
        //MeanStars = 0f;
        
       
        
        //DontDestroyOnLoad(this.gameObject);
        txt = number.GetComponent<Text>();
        Words = annoucement.GetComponent<Text>();
        Words.text = countingwords.ToString();
        Message= Message.GetComponent<Text>();
        //Words.text = countingwords.ToString();
        isRacing = true;
        star1.enabled = false;
        star1ImgOn = false;
        
        star2.enabled = false;
        star2ImgOn = false;
        star3.enabled = false;
        star3ImgOn = false;
        

    }
    
    public void Update()
    {
        if (Game_Flow2.Palabras[Image_Changer2.GetComponent<SpriteRenderer>().sprite.name]) {
            Soft = 0;
            Hard = 1;
        }
        else
        {
            Hard = 0;
            Soft = 1;

        }
        
        if (isRacing)
        {
            txt.text = currentTime.ToString("#.00");
            currentTime= currentTime+Time.deltaTime;
        }
        
        //case in which the child does not answer:
        
        if(currentTime >= 8f)
        {
            
            isRacing = false;
           // Message.text = "You are to slow!";
            countingwords = countingwords + 1;
            Words.text = countingwords.ToString();
            //StartCoroutine(Wait());
            //Rmv2.Waitother();
            
            numberofreload2 = numberofreload2 + 1;
            SceneManager.LoadScene("level2");
            
            
        }
        
        if (countingwords == 10)
        {
            //Debug.Log(Stars);
            if(Stars >= 20f)
            {
                SceneManager.LoadScene("2to3"); //load Scene "2to3"
            }
            else
            {
                SceneManager.LoadScene("RedoLevel2"); //load Scene 
            }
        }  
             
    }
    
        public void SoftAddScore()
        {
            d = 0;
            
        //currentTime = 0f;
        countingwords = countingwords+1;
        Words.text = countingwords.ToString();
        if (Soft == 1)
        {
            if (currentTime>0f  &&  currentTime<2f)
            {
                Stars = Stars+3;
                Message.text = "You are fast as a rocket!";
                star1.enabled = true;
                star1ImgOn = true;
                star2.enabled = true;
                star2ImgOn = true;
                star3.enabled = true;
                star3ImgOn = true;
            }
            
            if (currentTime>2f  &&  currentTime<4f)
            {
                Stars = Stars+2;
                Message.text = "You are right";
                star1.enabled = true;
                star1ImgOn = true;
                star2.enabled = true;
                star2ImgOn = true;
                star3.enabled = false;
                star3ImgOn = false;
            }
            
            if (currentTime>4f  &&  currentTime<5f)
            {
                Stars = Stars+ 1;
                Message.text = "You are right";
                star1.enabled = true;
                star1ImgOn = true;
                star2.enabled = false;
                star2ImgOn = false;
                star3.enabled = false;
                star3ImgOn = false;
            }
            Score = Score + 1; //Score = number of right words
            
            //ScoreText.text = Score.ToString();
            //Message.text = "You are right!";
            //Debug.Log(ScoreText.text);
            isRacing = false;
            
            //if (currentTime >= 5f)
            //{
                
              //  Message.text = "You're too slow!";
               // Debug.Log(ScoreText.text);
              //  isRacing = false;
           // }

        }
        else
        {
			Score = Score;
            Message.text = "You are Wrong!";
            //txt = GetComponent<Text>();
            isRacing = false;
            
            //Time.timeScale = 0f;
        }
    }
        
    public void HardAddScore()
    {
        c = 0;
        //currentTime = 0f;
        countingwords = countingwords+1;
        Words.text = countingwords.ToString();
        if (Hard == 1)
            
        {
            if (currentTime>0f  &&  currentTime<3f)
            {
                Stars = Stars+3;
                Message.text = "You are as fast as a rocket!";
                star1.enabled = true;
                star1ImgOn = true;
                star2.enabled = true;
                star2ImgOn = true;
                star3.enabled = true;
                star3ImgOn = true;
                
 
               
            }
            if (currentTime>3f  &&  currentTime<5f)
            {
                Stars = Stars+2;
                Message.text = "You are right";
                star1.enabled = true;
                star1ImgOn = true;
                star2.enabled = true;
                star2ImgOn = true;
                star3.enabled = false;
                star3ImgOn = false;
            }
            if (currentTime>5f  &&  currentTime<8f)
            {
                Stars = Stars+1;
                Message.text = "You are right";
                star1.enabled = true;
                star1ImgOn = true;
                star2.enabled = false;
                star2ImgOn = false;
                star3.enabled = false;
                star3ImgOn = false;
            }
            
            Score = Score + 1;
            
            //ScoreText.text = Score.ToString();
            
            //Debug.Log(ScoreText.text);
            isRacing = false;
            //endTime = currentTime;
            //if (currentTime >= 5f)
            //{
             //  Message.text = "You're too slow!";
              //  Debug.Log(ScoreText.text);
          //  }
            //currentTime = 0f;
        }
        else
        {
			//Score = Score;
            Message.text = "You are Wrong!";
            isRacing = false;
            //currentTime = 0f;
           



            //Time.timeScale = 0f;
        }
    }
    
    public void changescene()
    {
        SceneManager.LoadScene("PauseLevl2");
        
    }

    public void changescene2()
    {
        SceneManager.LoadScene("level2");
        
    }

    public void changescene3()
    {
        SceneManager.LoadScene("Menu");
        
    }



    public void Tricky()
    {
        c = Rmv2.a;
        d = Rmv2.b;
        Debug.Log(c);
        Debug.Log(d);
        if (c == 1)
        {
            HardAddScore();
            Rmv2.HardAddScore();
            c = 0;
        }

        if (d == 1)
        {
            SoftAddScore();
            Rmv2.SoftAddScore();
            d = 0;
        } 
        //changescene2();
    }
    
   /* IEnumerator Wait()
    {
        Debug.Log("Delay");
        yield return new WaitForSeconds(2);
        //SceneManager.LoadScene("level2");
    }*/
}
