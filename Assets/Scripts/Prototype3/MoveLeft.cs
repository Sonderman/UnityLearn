using UnityEngine;

namespace Prototype3
{
    public class MoveLeft : MonoBehaviour
    {
        public float speed = 10f;
        private float leftBound = -15f;
        private PlayerControllerP3 _playerControllerP3;
        void Start()
        {
            _playerControllerP3 = GameObject.Find("Player").GetComponent<PlayerControllerP3>();
        }

    
        void Update()
        {
            if (_playerControllerP3.gameOver == false)
            {
               transform.Translate(Vector3.left*Time.deltaTime*speed); 
            }

            if (transform.position.x < leftBound && gameObject.CompareTag("Obsticle"))
            {
                Destroy(gameObject);
            }
        }
    }
}
