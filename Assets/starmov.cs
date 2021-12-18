using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starmov : MonoBehaviour
{
    public Vector2 targetPos;
    private float speed = 80;
    public GameObject starprefab;
    public GameObject star;
    private int a;

    public List<float> PossPositionsx;


    void Awake()
    {
        int rand = Random.Range(0, PossPositionsx.Count);
        star = Instantiate(starprefab, position: new Vector3(x: PossPositionsx[rand], y: 280), Quaternion.identity);
        a = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (a == 1)
        {
            star.transform.Translate(Vector2.down * speed * Time.deltaTime);
            star.transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (star.transform.position.y <= -30)
            {
                Destroy(star);
                a = 0;
            }
        }

        if (a == 0)
        {
            Awake();
        }
    }
}
