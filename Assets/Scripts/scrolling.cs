using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling : MonoBehaviour
{
    public float speed = 40;
    public float minX = -383f;
    public float origin = 1147f;
    private void Update()
    {
        transform.Translate(translation: Vector2.down * (speed * Time.deltaTime));

        if(transform.position.y <= minX)
        {
            transform.position = new Vector2(x: transform.position.x, y: origin);
        }
    }
}
