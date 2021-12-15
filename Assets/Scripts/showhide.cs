using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class showhide : MonoBehaviour
{
    public GameObject explosion;
    public int Hard;
    public int Soft;
    public int i = 0;
    public int j = 1000;
    public void Awake()
    {
        explosion.SetActive(false);
    }
    

    public void show()
    {
        if (Hard == 1)
        {
            explosion.SetActive(true);
        }
    }
}
