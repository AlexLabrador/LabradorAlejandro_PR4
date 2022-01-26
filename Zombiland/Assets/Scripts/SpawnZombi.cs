using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombi : MonoBehaviour
{
    [SerializeField] GameObject[] ZombiePrefab;
    [SerializeField]  Transform[] spawnPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnear", 0.1f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawnear()
    {
        int i = Random.Range(0, 3);
        int s = Random.Range(0, 63);
        Instantiate(ZombiePrefab[i], spawnPoints[s].position, Quaternion.identity);
    }
}
