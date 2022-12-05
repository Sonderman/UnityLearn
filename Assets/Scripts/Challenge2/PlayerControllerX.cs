using UnityEngine;
using UnityEngine.InputSystem;

namespace Challenge2
{
    public class PlayerControllerX : MonoBehaviour
    {
        public GameObject dogPrefab;
        private float cooldown = 1f;
        private float time = 0f;

        // Update is called once per frame
        private void Update()
        {
            // On spacebar press, send dog
            if (Keyboard.current.spaceKey.wasPressedThisFrame&& Time.time> time +cooldown)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                time = Time.time;
            }
        }
    }
}
