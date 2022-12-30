using UnityEngine;

namespace Prototype3
{
    public class SpawnManagerP3 : MonoBehaviour
    {
        public GameObject ObsPrefab;
        private Vector3 spawnPos = new Vector3(25, 0, 0);
        private float spawnDelay = 2f;
        private float repeateRate = 2f;
        private PlayerControllerP3 _playerControllerP3;
        void Start()
        {
            _playerControllerP3 = GameObject.Find("Player").GetComponent<PlayerControllerP3>();
           InvokeRepeating(nameof(SpawnObs),spawnDelay,repeateRate);
           
        }

        private void SpawnObs()
        {
            if (_playerControllerP3.gameOver == false)
            {
                Instantiate(ObsPrefab, spawnPos, ObsPrefab.transform.rotation);
            }
            
        }
    }
}
