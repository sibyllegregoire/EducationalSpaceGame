using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collitionhard : MonoBehaviour
{
    
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
    public int c;
    public int d;
    public static int Score;
    //public Text ScoreText;
    public Text Message;
    public static int count;
    
    public void Awake()
    {
        
        Score = collitionhard.Score;
        //ScoreText.text = Score.ToString();
        countingwords = collitionhard.countingwords;
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
        if (Game_Flow3.Palabras[Image_Changer.GetComponent<SpriteRenderer>().sprite.name]) {
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
            count++;
            SceneManager.LoadScene("level3");
        }
        
        if (countingwords == 10)
        {
            //Debug.Log(Stars);
            if(Stars >= 20f)
            {
                SceneManager.LoadScene("win"); //load Scene "1to2"
            }
            else
            {
                countingwords = 0;
                Stars = 0;
                //numberofreload = 0;
                //numberofreload2 = 0;
                count = 0;

                Score = 0;
                //RocketMovements.numberofreload = 0;
                SceneManager.LoadScene("RedoLevel3"); //load Scene "RedoLevel
            }
        }  
             
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Laser"))
        {

            if (Hard == 1)
            {
                Debug.Log("Landing to Hard planet :)");
                HardAddScore();
            }
            else
            {
                Debug.Log("explosion");
            }
           // HardAddScore();
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
                count++;
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
                count++;
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
                count++;
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
            count++;
        }
    }
    
    public void changescene()
    {
        SceneManager.LoadScene("Test");
        
    }

    public void changescene2()
    {
        SceneManager.LoadScene("level3");
        
    }

    public void changescene3()
    {
        SceneManager.LoadScene("Menu");
        
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
                count++;
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
                count++;
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
                count++;
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
            count++;
            
            //Time.timeScale = 0f;
        }
    }
  
}
