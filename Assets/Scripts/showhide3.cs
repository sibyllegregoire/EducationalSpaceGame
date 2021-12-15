using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class showhide3 : MonoBehaviour
{
    public GameObject laser;
    public GameObject explosion;
    public GameObject explosionprefab;
    public float speed = 80f;

    public void Awake()
    {
        laser.SetActive(false);
        explosion.SetActive(false);
    }
    

    public void show()
    {
        laser.transform.localEulerAngles = new Vector3(x: 0, y: 0, z: 90);
        laser.SetActive(true);
        explosion.SetActive(true);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Hardplanet"))
        {
            Debug.Log("Landing to Hard planet");
            explosion = Instantiate(explosionprefab, new Vector2(laser.transform.position.x, laser.transform.position.y + 10),
                Quaternion.identity);
            explosion.GetComponent<showhide>().show();
            //laser.SetActive(false);
            StartCoroutine(Wait());
        }

        if (other.CompareTag("Softplanet"))
        {
            Debug.Log("Landing to Soft planet");
            explosion = Instantiate(explosionprefab, new Vector2(laser.transform.position.x, laser.transform.position.y + 10),
                Quaternion.identity);
            explosion.GetComponent<showhide>().show();
            //laser.SetActive(false);
            StartCoroutine(Wait());
        }
        
        IEnumerator Wait()
        {
            laser.SetActive(false);
            Debug.Log("Delay");
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("level3");
        }

    }
    
}
