using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerr : MonoBehaviour
{
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        Spawner();
    }

    async void Spawner()
    {
        while (true)
        {
            await new WaitForSeconds(Random.Range(0.5f,2f));
            GameObject obj = prefabs[Random.Range(0, prefabs.Length)];
            Vector3 pos =  transform.position + Vector3.right * Random.Range(-5f, 5f);
            Instantiate(prefabs[0], transform.position, Quaternion.identity);
        }
        

    }
    
}
