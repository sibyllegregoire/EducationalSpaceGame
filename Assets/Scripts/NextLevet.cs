using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevet : MonoBehaviour
{
    
    public void repeatlevel()
    {
        SceneManager.LoadScene("SampleScene");
        
    }
    
    public void repeatlevel2()
    {
        SceneManager.LoadScene("level2");
        
    }
    
    public void repeatlevel3()
    {
        SceneManager.LoadScene("level3");
        
    } 
    
    public void changescene()
    {
        SceneManager.LoadScene("Instructions2");
        
    }
    
    
    public void changescene4()
    {
        SceneManager.LoadScene("PauseLevl3");
        
    }
    
    public void changescene1()
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    public void changescene3()
    {
        SceneManager.LoadScene("level2");
        
    }
    
    public void changescene2()
    {
        SceneManager.LoadScene("level3");
        
    }
    
    public void changescene5()
    {
        SceneManager.LoadScene("Instructions3");
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
