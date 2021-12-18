using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collisionsoft : MonoBehaviour
{
    public int Soft3 = 0;
    public int Hard3 = 1;
    public collitionhard ch;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Laser"))
        {
            
                Debug.Log("Landing to soft planet :)");
                ch.SoftAddScore();

            // HardAddScore();
        }
    }
}
