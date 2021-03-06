using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.EventSystems;

public class winLose : MonoBehaviour
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
    public Transform Image_Changer;
    public float MeanStars;
    public static int countingwords;
    private Text Words;
    public Text number;
    public Text annoucement;
    public static int numberofreload;
    public RocketMovements Rmv;
    
    
    


    public void Awake()
	{
        
		Score = winLose.Score;
		//ScoreText.text = Score.ToString();
        countingwords = winLose.countingwords;
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

    // Update is called once per frame
    public void Update()
    {
        numberofreload = RocketMovements.numberofreload;
        if (Game_Flow.Palabras[Image_Changer.GetComponent<SpriteRenderer>().sprite.name]) {
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
        
        if(currentTime >= 5f)
        {
            
            isRacing = false;
            Message.text = "Sei troppo lento!";
            countingwords = countingwords + 1;
            Words.text = countingwords.ToString();
            SceneManager.LoadScene("SampleScene");
            numberofreload = RocketMovements.numberofreload;
            numberofreload = numberofreload + 1;
            

        }
        
        if (countingwords == 10)
        {
            //Debug.Log(Stars);
            if(Stars >= 20f)
            {
                SceneManager.LoadScene("1to2"); //load Scene "1to2"
            }
            else
            {
                countingwords = 0;
                Stars = 0;
                numberofreload = 0;
                Score = 0;
                RocketMovements.numberofreload = 0;
                SceneManager.LoadScene("RedoLevel"); //load Scene "RedoLevel"
                //countingwords = 0;
                //Stars = 0;
                //numberofreload = 0;
            }
        }  
             
     }
    //void Start()
    
        //isRacing = true;
    
//when the level is finished, so the 10 words are done:
        
    

    //public void YouWin()
	//{
      //  Message.text = "You Win!";
        //Time.timeScale = 0f;
        //txt = number.GetComponent<Text>();
        //isRacing = false;
        
        //Message.text = "Final Score";
        //Words.text = Score.ToString();
        //Stars.text = Stars.ToString();
    //}
    
 
    public void SoftAddScore()
    {
        //currentTime = 0f;
        countingwords = countingwords+1;
        Words.text = countingwords.ToString();
        if (Soft == 1)
        {
            if (currentTime>0f  &&  currentTime<2f)
            {
                Stars = Stars+3;
                Message.text = "Sei veloce come un razzo!";
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
                Message.text = "Corretto!";
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
                Message.text = "Corretto!";
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
            Message.text = "Hai sbagliato!";
            //txt = GetComponent<Text>();
            isRacing = false;
            
            //Time.timeScale = 0f;
        }
    }
    
    public void HardAddScore()
    {
        //currentTime = 0f;
        countingwords = countingwords+1;
        Words.text = countingwords.ToString();
        if (Hard == 1)
            
        {
            if (currentTime>0f  &&  currentTime<2f)
            {
                Stars = Stars+3;
                Message.text = "Sei veloce come un razzo!";
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
                Message.text = "Corretto!";
                star1.enabled = true;
                star1ImgOn = true;
                star2.enabled = true;
                star2ImgOn = true;
                star3.enabled = false;
                star3ImgOn = false;
            }
            if (currentTime>4f  &&  currentTime<5f)
            {
                Stars = Stars+1;
                Message.text = "Corretto!";
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
            Message.text = "Hai sbagliato!";
            isRacing = false;
            //currentTime = 0f;
           



            //Time.timeScale = 0f;
        }
    }
    
    
    

    public void changescene()
    {
        SceneManager.LoadScene("Test");
        
    }

    public void changescene2()
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    public void changescene3()
    {
        SceneManager.LoadScene("Menu");
        
    }

}
