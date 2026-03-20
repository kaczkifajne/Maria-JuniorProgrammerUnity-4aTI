using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPrefab;

    private float spawnRangeX = 15;
    private float spawnPosZ = 22;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // spawning random prefab from list at random X
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
                0, spawnPosZ);
            int animalIndex = Random.Range(0, spawnPrefab.Length);
            Instantiate(spawnPrefab[animalIndex], spawnPos,
                spawnPrefab[animalIndex].transform.rotation);
        }
    }
}
