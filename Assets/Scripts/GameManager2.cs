using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int t;
    private static bool _created = false;
    public static System.Random rng = new System.Random();
 
    //Accessible only trough editor or from this class
    [SerializeField]
    private List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,12,13,14,15,16,17,18, 19 , 20 , 21,22,23,24,25,26,27 };

    public List<int> list2public;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
