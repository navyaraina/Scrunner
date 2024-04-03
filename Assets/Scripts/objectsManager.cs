using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsManager : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint;
    [SerializeField] List<GameObject> obstaclesSpawn;


    //private float timer = 0.0f;


    //private void Update()
    //{
    //    timer += Time.deltaTime;
    //    if (Time.deltaTime == Random.Range(0.0f, 100.0f))
    //    {
    //        int num = Random.Range(0, obstaclesSpawn.Count);
    //        GameObject obj = obstaclesSpawn[num];
    //        Instantiate(obj, spawnPoint.transform.position, Quaternion.identity);

    //        timer = 0.0f;
    //    }
    //}

    static void InstantiatePrefab()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "barrier")
        {
            Destroy(other.gameObject);

            //int num = Random.Range(0, obstaclesSpawn.Count);
            //GameObject obj = obstaclesSpawn[num];
            //Instantiate(obj, spawnPoint.transform.position, Quaternion.identity);
        }
        
    }
}
