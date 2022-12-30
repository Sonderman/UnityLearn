using UnityEngine;

namespace Prototype3
{
    public class RepeatBackground : MonoBehaviour
    {
        private Vector3 startPos;
        private float repeateWith;
        void Start()
        {
            startPos = transform.position;
            repeateWith = GetComponent<BoxCollider>().size.x / 2;
        }
        
        void Update()
        {
            if (transform.position.x < startPos.x - repeateWith)
            {
                transform.position = startPos;
            }
        }
    }
}
