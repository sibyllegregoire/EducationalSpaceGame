using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevet : MonoBehaviour
{
    
    public void changescene()
    {
        SceneManager.LoadScene("level2");
        
    }
    
    public void repeatlevel()
    {
      SceneManager.LoadScene("SampleScene");
        
    }
    
    public void changescene1()
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    
    public void changescene2()
    {
        SceneManager.LoadScene("level3");
        
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
