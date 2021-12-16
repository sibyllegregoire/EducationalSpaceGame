using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;




    public class Game_Flow : MonoBehaviour
{


    public Transform FuerteObj;
    public Transform SuaveObj;
    public Transform ImageObj;
    public int imagePointer;
    public Transform Image_Changer;
    public Transform Word_Controller;
    //public string[] liststring;

    public static string currentSelection;
    public static int textPointer = 1;
    public static IDictionary<string, bool> Palabras = new Dictionary<string, bool>();

    public static System.Random rng = new System.Random();

    public static List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public static List<string> list_of_Keys=new List<string>{"gambe","gambero","gambo","ganci","gatto","gelato","gemelli","gengiva","genio","ghepardo"};
    Boolean[] list_of_value = new Boolean[] {true, true, true, true, true, false, false, false, false, true};
    private int p;
    
  



    // Start is called before the first frame update
     public void Start()
    {

        //int n = winLose.countingwords;;
        //while (n > 1)
        //{
           // n--;
            //int k = rng.Next(n + 1);
            //int T = list1[k];
            //list1[k] = list1[n];
            //list1[n] = T; 
        //}

    
    
        Palabras.Add("gambe",true); //adding a key/value using the Add() method
        Palabras.Add("gambero",true); // true = hard
        Palabras.Add("gambo",true);
        Palabras.Add("ganci", true);
        Palabras.Add("gatto", true);
        Palabras.Add("gelato", false);
        Palabras.Add("gemelli", false);
        Palabras.Add("gengiva", false);
        Palabras.Add("genio", false);
        Palabras.Add("ghepardo", true);

    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentSelection);
        //if (currentSelection == "Forte" & Palabras[Image_Changer.GetComponent<SpriteRenderer>().sprite.name] == true){Debug.Log("Correct");}
        //else if (currentSelection == "Tenue" & Palabras[Image_Changer.GetComponent<SpriteRenderer>().sprite.name] == false){Debug.Log("Correct");}
        //else{Debug.Log("Incorrect");}
        
        //List<string> liststring =global::Image_Changer.list_of_string_already_used;
        //p= 0;
        //foreach (var u in list_of_Keys)
        //{ 
            //if (liststring.Contains(u))
            //{
                //Debug.Log("Already use");
            //}
            //else
            //{
                //Palabras.Add(u,list_of_value[p]);
                //p = p + 1;
            //}
            
        //}
        Word_Controller.GetComponent<TextMesh>().text = Image_Changer.GetComponent<SpriteRenderer>().sprite.name;
        
    }

   

}


