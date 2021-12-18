using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class showhide3 : MonoBehaviour
{
    //public static int Score3;
    //public Text scoreText3;
    public int Soft3 = 0;
    public int Hard3 = 1;
    public GameObject laser;
    public GameObject explosion;
    public GameObject explosionprefab;
    public float speed = 80f;
    public static int b;
    public int x;
    public int y;
    //public WinLose3 wl3;

    public void Awake()
    {
        laser.SetActive(false);
        explosion.SetActive(false);
        b = 0;
    }
    

    public void show()
    {
        laser.transform.localEulerAngles = new Vector3(x: 0, y: 0, z: 90);
        laser.SetActive(true);
        explosion.SetActive(true);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        b = 1;
        Debug.Log(b);
        if (other.CompareTag("Hardplanet"))
        {
            Debug.Log("Landing to Hard planet");
            explosion = Instantiate(explosionprefab, new Vector2(laser.transform.position.x, laser.transform.position.y + 10),
                Quaternion.identity);
            explosion.GetComponent<showhide>().show();
            x = 1;
            HardAddScore();
            //laser.SetActive(false);
        }

        if (other.CompareTag("Softplanet"))
        {
            Debug.Log("Landing to Soft planet");
            explosion = Instantiate(explosionprefab, new Vector2(laser.transform.position.x, laser.transform.position.y + 10),
                Quaternion.identity);
            explosion.GetComponent<showhide>().show();
            y = 1;
            SoftAddScore();
            //laser.SetActive(false);
        }
        //wl3.Tricky();
    }
    
    IEnumerator Wait()
    {
        laser.SetActive(false);
        Debug.Log("Delay here");
        //b = 0;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("level3");
    }

    public void HardAddScore()
    {
        Debug.Log("oli1");
        if (Hard3 == 1)
        {
            //Score3++;
            //scoreText3.text = Score3.ToString();
            //Debug.Log(Score3);
            StartCoroutine(Wait());
        }
        else
        {
            //Score3 = Score3;
            //scoreText2.text = "You are Wrong!";
            //Time.timeScale = 0f;
            //scoreText3.text = "You are Wrong!";
            StartCoroutine(Wait());
        }
        //wl3.Tricky();
    }
    
    public void SoftAddScore()
    {
        Debug.Log("oli2");
        if (Soft3 == 1)
        {
            //Score3++;
            //scoreText3.text = Score3.ToString();
            //Debug.Log(ScoreText.text);
            //Debug.Log(Score3);
            StartCoroutine(Wait());
        }
        else
        {
            //Score3 = Score3;
            //Time.timeScale = 0f;
            //scoreText3.text = "You are Wrong!";
            StartCoroutine(Wait());
        }
        //wl3.Tricky();
    }
    
}
