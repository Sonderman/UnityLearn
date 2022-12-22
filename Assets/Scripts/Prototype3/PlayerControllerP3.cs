using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Prototype3
{
    public class PlayerControllerP3 : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        public float jumpForce;
        public float gravityModifier;
        public bool isOnGround = true;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            Physics.gravity *= gravityModifier;
        }

        private void Update()
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame && isOnGround)
            {
                _rigidbody.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
                isOnGround = false;
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            isOnGround = true;
        }
    }
}
