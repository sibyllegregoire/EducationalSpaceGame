using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject Rockprefab;

    public List<float> PossPositionsx;
    public List<float> PossPositionsy;
     

    private void Awake()
    {
        int rand = Random.Range(0, PossPositionsx.Count);
        Instantiate(Rockprefab, position: new Vector3(x: PossPositionsx[rand], y: PossPositionsy[rand]),
            Quaternion.identity);
        int rand2 = Random.Range(0, PossPositionsx.Count);
        Instantiate(Rockprefab, position: new Vector3(x: PossPositionsx[rand2], y: PossPositionsy[rand2]),
            Quaternion.identity);
    }
    
}
