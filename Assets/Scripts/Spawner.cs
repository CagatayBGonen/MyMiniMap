using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectPrefab;
    private float spawnPositionX;
    private float spawnPositionZ;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            spawnPositionX = Random.Range(-49f,50f);
            spawnPositionZ = Random.Range(-49f,50f);

            Instantiate(objectPrefab,new Vector3(spawnPositionX,transform.position.y,spawnPositionZ), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
