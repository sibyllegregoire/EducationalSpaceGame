using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RocketMovLvl2 : MonoBehaviour
{
    
    public static int Score2;
    public Text scoreText2;
    public int Soft2 = 0;
    public int Hard2 = 1;
    //public GameObject rocket;
    
    float increment = 30;
    float decrement = 30;
    public Vector2 targetPos;
    public float speed = 100f;
    
    public float limitup = 290f;
    public float limitdown = 25f;
    public float limitright = 370f;
    public float limitleft = 25f;

    public GameObject explosion;
    public GameObject explosionprefab;
    public void Awake()
    {
        //targetPos = new Vector2(x: -11, y: 0);
        targetPos = transform.position;
        Score2 = RocketMovLvl2.Score2;
        scoreText2.text = Score2.ToString();
    }

    public void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if(Score2 >= 10)
        {
            YouWin();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Hardplanet"))
        {
            Debug.Log("Landing to Hard planet");
            HardAddScore();
        }

        if (other.CompareTag("Softplanet"))
        {
            Debug.Log("Landing to Soft planet");
            SoftAddScore();
        }

        if (other.CompareTag("Rock"))
        {
            Debug.Log("Rock contact");
            Rockcontact();
        }
    }

    public void moveUp()
    {
        //transform.position = new Vector3(x: transform.position.x, y: transform.position.y + increment, z: 0);
        if (transform.position.y >= limitup)
        {
            targetPos = new Vector2(x: transform.position.x, y: limitup);
        }
        else
        {
            targetPos = new Vector2(x: transform.position.x, y: transform.position.y + increment);
            transform.localEulerAngles = new Vector3(x: 0, y: 0, z: 0);
        }
    }

    public void moveDown()
    {
        //transform.position = new Vector3(x: transform.position.x, y: transform.position.y - decrement, z: 0);
        if (transform.position.y <= limitdown)
        {
            targetPos = new Vector2(x: transform.position.x, y: limitdown);
        }
        else
        {
            targetPos = new Vector2(x: transform.position.x, y: transform.position.y - decrement);
            transform.localEulerAngles = new Vector3(x: 0, y: 0, z: 180);
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
            transform.localEulerAngles = new Vector3(x: 0, y: 0, z: -90);
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
            transform.localEulerAngles = new Vector3(x: 0, y: 0, z: 90);
        }
    }
    
    public void HardAddScore()
    {
        if (Hard2 == 1)
        {
            Score2++;
            scoreText2.text = Score2.ToString();
            Debug.Log(Score2);
            StartCoroutine(Wait());
        }
        else
        {
            Score2 = Score2;
            //scoreText2.text = "You are Wrong!";
            //Time.timeScale = 0f;
            explosion = Instantiate(explosionprefab, new Vector2(transform.position.x, transform.position.y + 10),
                Quaternion.identity);
            explosion.GetComponent<showhide>().show();
            scoreText2.text = "You are Wrong!";
            StartCoroutine(Wait());
        }
    }
    
    public void SoftAddScore()
    {
        if (Soft2 == 1)
        {
            Score2++;
            scoreText2.text = Score2.ToString();
            //Debug.Log(ScoreText.text);
            Debug.Log(Score2);
            StartCoroutine(Wait());
        }
        else
        {
            Score2 = Score2;
            //Time.timeScale = 0f;
            explosion = Instantiate(explosionprefab, new Vector2(transform.position.x, transform.position.y + 10),
                Quaternion.identity);
            explosion.GetComponent<showhide>().show();
            scoreText2.text = "You are Wrong!";
            StartCoroutine(Wait());
        }
    }

    public void Rockcontact()
    {
        explosion = Instantiate(explosionprefab, new Vector2(transform.position.x, transform.position.y + 10),
            Quaternion.identity);
        explosion.GetComponent<showhide>().show();
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        Debug.Log("Delay");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("level2");
    }

    public void YouWin()
    {
        Debug.Log("You Win!");
        scoreText2.text = "You Win!";
        Time.timeScale = 0f;
    }
    
}
