using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;

public class cometmov : MonoBehaviour
{
    public Vector2 targetPos;
    private float speed = 40;
    public GameObject explosion;
    public GameObject explosionprefab;
    public GameObject cometprefab;
    public GameObject comet;
    private int a;

    public List<float> PossPositionsx;


    void Awake()
    {
        int rand = Random.Range(0, PossPositionsx.Count);
        comet = Instantiate(cometprefab, position: new Vector3(x: PossPositionsx[rand], y: 280), Quaternion.identity);
        a = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (a == 1)
        {
            comet.transform.Translate(Vector2.down * speed * Time.deltaTime);
            comet.transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (comet.transform.position.y <= -30)
            {
                Destroy(comet);
                a = 0;
            }
        }

        if (a == 0)
        {
            Awake();
        }
    }
}
