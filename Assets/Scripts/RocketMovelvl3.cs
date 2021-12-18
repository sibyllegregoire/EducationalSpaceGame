using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RocketMovelvl3 : MonoBehaviour
{
    float increment = 30;
    float decrement = 30;
    public Vector2 targetPos;
    public Vector2 targetPoslaser;
    public float speed = 100f;
    public GameObject Laser;
    public GameObject Laserprefab;
    public int a;
    public Text scoreText3;
    public float limitright = 370f;
    public float limitleft = 25f;
    public showhide3 Showhide3;
    public comettrig Comettrig;
    public int c;
    public int i = 0;
    
    public void Awake()
    {
        //targetPos = new Vector2(x: -11, y: 0);
        targetPos = transform.position;
        Debug.Log("Holi");
    }
    

    // Update is called once per frame
    public void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (a == 1)
        {
            Laser.transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (Laser.transform.position.y >= 255)
            {
                Destroy(Laser);
                a = 0;
            }
        }
        //scoreText3.text = showhide3.Score3.ToString();
        c = showhide3.b;
        Debug.Log("RocketMov3");
        Debug.Log(i);
        i = comettrig.j;
        if (c == 1 || i == 1)
        {
            StartCoroutine(Wait());
        }
    }
    
    public void moveRight()
    {
        //transform.position = new Vector3(x: transform.position.x, y: transform.position.y + increment, z: 0);
        if (transform.position.x >= limitright)
        {
            targetPos = new Vector2(x: limitright, y: transform.position.y);
        }
        else
        {
            targetPos = new Vector2(x: transform.position.x + increment, y: transform.position.y);
            //transform.localEulerAngles = new Vector3(x: 0, y: 0, z: -90);
        }
    }

    public void moveLeft()
    {
        //transform.position = new Vector3(x: transform.position.x, y: transform.position.y + increment, z: 0);
        if (transform.position.x <= limitleft)
        {
            targetPos = new Vector2(x: limitleft, y: transform.position.y);
        }
        else
        {
            targetPos = new Vector2(x: transform.position.x - decrement, y: transform.position.y);
            //transform.localEulerAngles = new Vector3(x: 0, y: 0, z: 90);
        }
    }

    public void shoot()
    {
        if (a == 0)
        {
            Laser = Instantiate(Laserprefab, new Vector2(transform.position.x, transform.position.y + 38),
                Quaternion.identity);
            Laser.GetComponent<showhide3>().show();
            //targetPoslaser = new Vector2(x: Laser.transform.position.x, y: Laser.transform.position.y + 200);
            //Laser.transform.position = Vector2.MoveTowards(Laser.transform.position, targetPoslaser, speed * Time.deltaTime);
            //Laser = Instantiate(Laserprefab, transform.position, Quaternion.identity);
            //Laser.GetComponent<showhide3>().show();
            a = 1;
        }
    }

    IEnumerator Wait()
    {
        Debug.Log("Delay here");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("level3");
    }
    
}
