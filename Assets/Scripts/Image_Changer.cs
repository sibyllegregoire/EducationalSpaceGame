using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image_Changer : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    string name_of_image = "image"+ Game_Flow.list1[Game_Flow.textPointer];
    
    Sprite result = (Sprite)this.GetType().GetField(name_of_image).GetValue(this);
    GetComponent<SpriteRenderer>().sprite = result;

    }
}
