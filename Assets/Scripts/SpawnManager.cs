using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint;
    [SerializeField] List<GameObject> prefabsToSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            Destroy(other.gameObject);

            int index = Random.Range(0, prefabsToSpawn.Count);
            GameObject spawner = prefabsToSpawn[index];
            Instantiate(spawner, spawnPoint.transform.position, Quaternion.identity);
        }
        if (other.gameObject.tag == "gems")
        {
            Destroy(other.gameObject);
        }
    }
}
