using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class showhide2 : MonoBehaviour
{
    public GameObject explosion2;
    public int Hard;
    public int Soft;
    public void Awake()
    {
        explosion2.SetActive(false);
    }

    public void hide()
    {
        if (Soft == 1)
        {
            explosion2.SetActive(true);
        }
    }
}