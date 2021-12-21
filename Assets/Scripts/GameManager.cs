using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static bool _created = false;
    private static bool _created2 = false;
    public static System.Random rng = new System.Random();
 
    //Accessible only trough editor or from this class
    [SerializeField]
    private List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,12,13,14,15,16,17,18, 19 , 20 , 21,22,23,24,25,26,27 };

    private List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,12,13,14,15,16,17,18 };

    public List<int> list1public;
    public List<int> list2public;
    //private List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,12,13,14,15,16,17,18, 19 , 20 , 21,22,23,24,25,26,27 };

    
 
    //public int livesLeft;

    // Start is called before the first frame update
    void Start()
    {
        if (!_created)
                {
                    int n = list1.Count;
                    while (n > 1)
                    {
                      n--;
                    int k = rng.Next(n + 1);
                    int T = list1[k];
                    list1[k] = list1[n];
                    list1[n] = T; 
                    }
                  
                    DontDestroyOnLoad(this.gameObject);
                    _created = true;
                   
                    Init();
                }
        if (!_created2)
        {
           
            int n = list2.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int T = list2[k];
                list2[k] = list2[n];
                list2[n] = T; 
            }
            DontDestroyOnLoad(this.gameObject);
           
            _created2 = true;
            Init2();
        }
    }

    // Update is called once per frame
    void Init()
    {
        list1public = list1;
        
    }
    void Init2()
    {
        list2public = list2;
       
    }
}
