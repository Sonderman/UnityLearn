using UnityEngine;

namespace Challenge2
{
    public class SpawnManagerX : MonoBehaviour
    {
        public GameObject[] ballPrefabs;

        private float spawnLimitXLeft = -30;
        private float spawnLimitXRight = 7;
        private float spawnPosY = 25;

        private float startDelay = 1.0f;
        private float spawnInterval = 2.0f;

        // Start is called before the first frame update
        private void Start()
        {
            InvokeRepeating(nameof(SpawnRandomBall), startDelay, spawnInterval);
        }

        // Spawn random ball at random x position at top of play area
        private void SpawnRandomBall ()
        {
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
            int randomindex = Random.Range(0, 3);
            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[randomindex], spawnPos, ballPrefabs[randomindex].transform.rotation);
            spawnInterval = Random.Range(3, 5);
        }

    }
}
