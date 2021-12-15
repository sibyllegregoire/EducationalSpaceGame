using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Next : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
    if (Game_Flow.textPointer<10)
        {Game_Flow.textPointer=Game_Flow.textPointer+1;}
    }
}
