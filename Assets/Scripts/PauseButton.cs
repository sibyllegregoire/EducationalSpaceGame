using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.EventSystems;

public class PauseButton : MonoBehaviour 
{
        
    public static int countingwords; 
    public Text Words;
    public Text countingword;
    
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countingwords = winLose.countingwords;
        Words = countingword.GetComponent<Text>();
        Words.text = countingwords.ToString();
    }
}
