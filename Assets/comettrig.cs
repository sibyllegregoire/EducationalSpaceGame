using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comettrig : MonoBehaviour
{
    public GameObject explosion;
    public GameObject explosionprefab;
    public GameObject comet;
    public static int j;
    void Awake()
    {
        j = 0;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            j = 1;
            explosion = Instantiate(explosionprefab, new Vector2(comet.transform.position.x - 20, comet.transform.position.y - 20),
                Quaternion.identity);
            explosion.SetActive(true);
            Debug.Log("Explosion");
        }
    }
}
