using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;
public class RocketMovements : MonoBehaviour
{
    public Vector2 targetPos;
    private float speed = 150;
    public GameObject explosion;
    public GameObject explosionprefab;
    public int Hard = 1;
    public int Soft = 0;
    
    public float limit = 228;
    private Vector3 position1 = new Vector3(x: 82, y: 214, z: 0);
    private Vector3 position0 = new Vector3(x: 231, y: 25, z: 0);
    private Vector3 position2 = new Vector3(x: 364, y: 214, z: 0);
    private Vector3 rotationhard = new Vector3(x: 0, y: 0, z: 45);
    private Vector3 rotationsoft = new Vector3(x: 0, y: 0, z: 315);
    private int rot;

    IEnumerator Wait()
    {
        //rot = 0;
        Debug.Log("Delay");
        landing();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SampleScene");
        //transform.position = position0;
    }

    public  void landing()
    {
        Debug.Log("landing");
        transform.localEulerAngles = new Vector3(x: 0, y: 0, z: 0);

        if ((rot == 1) && (Hard == 0))
        {
            explosion = Instantiate(explosionprefab, new Vector2(transform.position.x, transform.position.y - 10),
                Quaternion.identity);
            explosion.GetComponent<showhide>().show();
            rot = 0;
        }

        if (rot == 1 && Hard == 1)
        {
            Debug.Log("Correct");
            rot = 0;
        }
        if ((rot == 2) && (Hard == 1))
        {
            explosion = Instantiate(explosionprefab, new Vector2(transform.position.x, transform.position.y - 10),
                Quaternion.identity);
            explosion.GetComponent<showhide>().show();
            rot = 0;
        }

        if (rot == 2 && Hard == 0)
        {
            Debug.Log("Correct");
            rot = 0;
        }        
        
    }

    public void Awake()
    {
        targetPos = new Vector2(x: 231, y: 25);
        transform.localEulerAngles = new Vector3(x: 0, y: 0, z: 0);
        //targetPos = transform.position;
    }

    public void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (transform.position.y == 214)
        {
            StartCoroutine(Wait());
            //transform.position = position0;
        }

        if (rot == 1)
        {
            transform.localEulerAngles = rotationhard;
        }
        if (rot == 2)
        {
            transform.localEulerAngles = rotationsoft;
        }
    }

    public void moveUp()
    {
        //transform.position = new Vector3(x: transform.position.x, y: transform.position.y + increment, z: 0);
        targetPos = position1;
        Debug.Log("active1");
        rot = 1;
    }

    public void moveDown()
    {
        //transform.position = new Vector3(x: transform.position.x, y: transform.position.y - decrement, z: 0);
        targetPos = position2;
        Debug.Log("active2");
        rot = 2;
    }
}