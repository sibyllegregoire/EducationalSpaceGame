using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.EventSystems;

public class WinLevel : MonoBehaviour 
{
        
    public static int Score;
    public Text Scoretext;
    public Text Scoring;

    public static float Stars;
    public Text Starstext;
    public Text Star;
    
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score = winLose.Score;
        Scoretext = Scoring.GetComponent<Text>();
        Scoretext.text = Score.ToString();
        
        Stars = winLose.Stars;
        Starstext = Star.GetComponent<Text>();
        Starstext.text = Stars.ToString();
    }
}