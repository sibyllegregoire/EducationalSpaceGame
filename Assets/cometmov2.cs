using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cometmov2 : MonoBehaviour
{
    public Vector2 targetPos;
    private float speed = 30;
    public GameObject comet2prefab;
    public GameObject comet2;
    private int a;

    public List<float> PossPositionsx;


    void Awake()
    {
        int rand = Random.Range(0, PossPositionsx.Count);
        comet2 = Instantiate(comet2prefab, position: new Vector3(x: PossPositionsx[rand], y: -10), Quaternion.identity);
        a = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (a == 1)
        {
            comet2.transform.Translate(Vector2.up * speed * Time.deltaTime);
            comet2.transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (comet2.transform.position.y >= 150)
            {
                Destroy(comet2);
                a = 0;
            }
        }

        if (a == 0)
        {
            Awake();
        }
    }
}
