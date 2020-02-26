using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject PipeSetPrefab;
    public float SpawnRate;
    public Transform spawnPosition; 


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipeSet", 0, SpawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void SpawnPipeSet ()
    {
        Instantiate(PipeSetPrefab, spawnPosition.position, Quaternion.identity);
    }
}
