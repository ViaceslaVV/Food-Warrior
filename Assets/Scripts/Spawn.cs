using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", 1f,1f);
    }

    void Spawner()
    {
        Instantiate(prefab,transform.position,Quaternion.identity);
    }
    
}
