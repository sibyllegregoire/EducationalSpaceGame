using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Image_Changer : MonoBehaviour
{

    public Sprite gambe;
    public Sprite gambero;
    public Sprite ganci;
    public Sprite gatto;
    public Sprite gelato;
    public Sprite gallina;
    public Sprite ghiacchiolo;
    public Sprite ghiande;
    public Sprite ghiro;
    public Sprite gigante;
    public Sprite ginocchio;
    public Sprite gomitollo;
    public Sprite gomme;
    public Sprite gorilla;
    public Sprite guanto;
    public Sprite gufo;
    public Sprite guinzaglio;
    public Sprite genio;
    public List<string> list_of_string_already_used;
    public static List<string> list_of_Keys2=new List<string>{"gambe","gambero","gambo","ganci","gatto","gelato","gemelli","gengiva","genio","ghepardo"};
    
    
    public static System.Random rng = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        int random_number = rng.Next(1,winLose.countingwords+1);
        //string name_of_image = "image" + Game_Flow.list1[Game_Flow.textPointer];
        string name_of_image = list_of_Keys2[random_number];
        
        Sprite result = (Sprite)this.GetType().GetField(name_of_image).GetValue(this);
        GetComponent<SpriteRenderer>().sprite = result;
     
        list_of_Keys2.Remove(name_of_image);
        
    }

    // Update is called once per frame
    void Update()
    {
        



    

    }
}
