using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class GameManager22 : MonoBehaviour
{
    private static bool _created = false;
    public static System.Random rng = new System.Random();
 
    //Accessible only trough editor or from this class
    [SerializeField]
    private List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,12,13,14,15,16,17,18, 19 , 20 , 21,22,23,24,25,26,27 };

    public List<int> list2public;
 
    //public int livesLeft;

    // Start is called before the first frame update
    void Start()
    {
        if (!_created)
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
            _created = true;
            Init();
        }
    }

    // Update is called once per frame
    void Init()
    {
        list2public = list2;
    }
}
