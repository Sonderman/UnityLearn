using UnityEngine;
using UnityEngine.InputSystem;

namespace Prototype3
{
    public class PlayerControllerP3 : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private Animator playerAnim;
        [SerializeField]
        private ParticleSystem _dyingParticleSystem;
        [SerializeField] private ParticleSystem _dirtParticleSystem;
        private AudioSource _audioSource;
        public AudioClip JumpSound;
        public AudioClip CrashSound;
        public float jumpForce;
        public float gravityModifier;
        public bool isOnGround = true;
        public bool gameOver = false;
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            playerAnim = GetComponent<Animator>();
            _audioSource = GetComponent<AudioSource>();
            Physics.gravity *= gravityModifier;
        }

        private void Update()
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame && isOnGround && !gameOver)
            {
                _rigidbody.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
                isOnGround = false;
                playerAnim.SetTrigger("Jump_trig");
                _dirtParticleSystem.Stop();
                _audioSource.PlayOneShot(JumpSound,1f);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isOnGround = true;
                _dirtParticleSystem.Play();
            }
            else if (collision.gameObject.CompareTag("Obsticle"))
            {
                gameOver = true;
                playerAnim.SetBool("Death_b",true);
                playerAnim.SetInteger("DeathType_int",1);
                _dyingParticleSystem.Play();
                _dirtParticleSystem.Stop();
                _audioSource.PlayOneShot(CrashSound,1f);
            }
            
        }
    }
}
