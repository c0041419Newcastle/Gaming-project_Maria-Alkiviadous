using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] myObjects;
    public System.Random rng;
    //This is use of stochastic behaviour. Simple, but still stochastic behaviour!
    public static double enemyThreshold = 0.7;

    // Start is called before the first frame update
    void Start()
    {
        rng = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (rng.NextDouble() < enemyThreshold)){
            int randomIndex = Random.Range(0,myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(40,30), 5, Random.Range(40, 30));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
        
    }
}
