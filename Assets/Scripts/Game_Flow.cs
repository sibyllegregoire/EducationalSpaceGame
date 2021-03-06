
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Android;
using UnityEngine.SceneManagement;



public class Game_Flow : MonoBehaviour
{
    public static System.Random rng = new System.Random();

    public Transform FuerteObj;
    public Transform SuaveObj;
    public Transform ImageObj;
    public int imagePointer;
    public Transform Image_Changer;
    public Transform Word_Controller;
    public GameObject PlaySoundButton;
    public Text SoundInstruction;

    public int rndsound;
    
    
    
    //public string[] liststring;

    public static string currentSelection;
    public static int textPointer = 1;
    public static IDictionary<string, bool> Palabras = new Dictionary<string, bool>();

    
    //public static List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,12,13,14,15,16,17,18 };
    //public static List<string> list_of_Keys=new List<string>{"gambe","gambero","ganci","gatto","gelato","gallina",
    //"ghiacciolo","ghiande","ghiro","ginocchio","gomitolo","gomme","gorilla","guanto","gufo",
    //"guinzaglio","genio"};
    //Boolean[] list_of_value = new Boolean[] {true, true, true, true, false, true, true, true, true, true, false,
        //false, true, true, true, true, true, true, false};
    //private int p;
    
  



    // Start is called before the first frame update
     public void Start()
    {
        //rndsound = Random.Range(1, 9);

        
       //int n = list1.Count;
              //while (n > 1)
              //{
                //  n--;
                  //int k = rng.Next(n + 1);
                  //int T = list1[k];
                  //list1[k] = list1[n];
                  //list1[n] = T; 
              //}
      
              

        PlaySoundButton.SetActive(false);
        if (!Palabras.ContainsKey("gambe"))
        {
            Palabras.Add("gambe",true); //adding a key/value using the Add() method
            Palabras.Add("gambero",true); // true = hard
            Palabras.Add("ganci", true);
            Palabras.Add("gatto", true);
            Palabras.Add("gelato", false);
            Palabras.Add("gallina", true);
            Palabras.Add("ghiacciolo", true);
            Palabras.Add("ghiande", true);
            Palabras.Add("ghiro", true);
            Palabras.Add("gigante", false);
            Palabras.Add("ginocchio",false);
            Palabras.Add("gomitolo", true);
            Palabras.Add("gomme", true);
            Palabras.Add("gorilla", true);
            Palabras.Add("guanto", true);
            Palabras.Add("gufo", true);
            Palabras.Add("guinzaglio", true);
            Palabras.Add("genio", false);
        }

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

        wordOrSound();

    }

    
    public void wordOrSound()
    {

        //Debug.Log(rndsound);
        //if (winLose.countingwords != rndsound) TODO for selecting randon numb for reproducing sound
        //StartCoroutine(Wait());
        if (winLose.countingwords != 9)
        {

        Word_Controller.GetComponent<TextMesh>().text = Image_Changer.GetComponent<SpriteRenderer>().sprite.name;
        }

        else
        {

         //TODO delay on show of instruction and audio
         PlaySoundButton.SetActive(true);
         SoundInstruction.text = "Clicca qui per ascoltare la parola";
         GetComponent<AudioWordsPlayer>().PlayWord();


        }
    }
    IEnumerator Wait()
    {
        //rot = 0;
        //Debug.Log("Delay");
        //landing();
        yield return new WaitForSeconds(2);
        //SceneManager.LoadScene("SampleScene");
        //numberofreload = numberofreload + 1;
        
        
        //transform.position = position0;
    }


}
