using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_FoS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("hi Majo");
    }

    // Update is called once per frame
    void Update()
    {
    
    }


    void OnMouseDown()
    {
        //Debug.Log("hi");
        //Debug.Log(gameObject.name);
        Game_Flow.currentSelection=gameObject.name;
    }

}
