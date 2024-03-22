using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint;
    [SerializeField] List<GameObject> prefabsToSpawn;
    [SerializeField] List <GameObject> obstaclesSpawn;


    private float timer = 0.0f;


    private void Update()
    {
        timer += Time.deltaTime;
        if (timer == Random.Range(5.0f,20.0f))
        {
            int num = Random.Range(0, obstaclesSpawn.Count);
            GameObject obj = obstaclesSpawn[num];
            Instantiate(obj, new Vector3(-1.08f, 0.75f, 4.4f), Quaternion.identity);

            timer = 0.0f;
        }

        if (timer == Random.Range(1.0f, 5.0f))
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            Destroy(other.gameObject);

            int index = Random.Range(0, prefabsToSpawn.Count);
            GameObject spawner = prefabsToSpawn[index];
            Instantiate(spawner, spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
