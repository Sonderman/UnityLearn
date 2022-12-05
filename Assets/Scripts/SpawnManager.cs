using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int spawnRangeX=20;
    public int spawnPosZ=20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal),startDelay,spawnInterval);
    }
    void SpawnRandomAnimal()
    {
        var index = Random.Range(0,3);
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),  Random.Range(10, spawnPosZ),0);
        Instantiate(animalPrefabs[index], spawnPos,animalPrefabs[index].transform.rotation);
        Debug.Log("Ball Spawn oldu");
    }
}
