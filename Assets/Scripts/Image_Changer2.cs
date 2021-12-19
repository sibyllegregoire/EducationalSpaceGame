using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Image_Changer2 : MonoBehaviour
{

    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public Sprite image5;
    public Sprite image6;
    public Sprite image7;
    public Sprite image8;
    public Sprite image9;
    public Sprite image10;
    public Sprite image11;
    public Sprite image12;
    public Sprite image13;
    public Sprite image14;
    public Sprite image15;
    public Sprite image16;
    public Sprite image17;
    public Sprite image18;
    
    //public List<string> list_of_string_already_used;
    //public static List<string> list_of_Keys2=new List<string>{"gambe","gambero","ganci","gatto","gelato","gallina", "ghiacciolo","ghiande","ghiro","ginocchio","gomitolo","gomme","gorilla","guanto","gufo",
    //"guinzaglio","genio"};
    
    
    public static System.Random rng = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        int rndaudio = Random.Range(1, 10);
        Debug.Log(rndaudio);


        //int random_number = rng.Next(1,winLose.countingwords+1);
        //string name_of_image = "image" + Game_Flow.list1[Game_Flow.textPointer];
        //string name_of_image = list_of_Keys2[random_number];

        //Sprite result = (Sprite)this.GetType().GetField(name_of_image).GetValue(this);
        //GetComponent<SpriteRenderer>().sprite = result;

        //list_of_Keys2.Remove(name_of_image);

    }

    // Update is called once per frame
    void Update()
    {
        string name_of_image = "image" + Game_Flow2.list1[Game_Flow2.textPointer];
        Sprite result = (Sprite)this.GetType().GetField(name_of_image).GetValue(this);
        GetComponent<SpriteRenderer>().sprite = result;

    }
}