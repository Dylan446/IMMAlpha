using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject keyPrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 10);
    private Vector3 spawnPos2 = new Vector3(12, 0, 20);
    private Vector3 spawnPos3 = new Vector3(-12, 0, 22);

    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(keyPrefab, spawnPos, keyPrefab.transform.rotation);
        Instantiate(keyPrefab, spawnPos2, keyPrefab.transform.rotation);
        Instantiate(keyPrefab, spawnPos3, keyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
    }
}
