
using UnityEngine;
using UnityEngine.InputSystem;

public class Farmer : MonoBehaviour
{
    private Vector2 _axis;
    [SerializeField] public float speed = 1f;
    [SerializeField] public float xRange = 1f;
    [SerializeField] public GameObject foodPrefab;
    private SpawnManager _spawnManager;

    private void Start()
    {
        _spawnManager = FindObjectOfType<SpawnManager>();
    }

    public void OnMove(InputValue value)
    {
        _axis = value.Get<Vector2>();
    }
    public void OnActions(InputValue value){
        
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(foodPrefab, transform.position, Quaternion.identity);
        }

        /*if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            _spawnManager.SpawnAnimal();
        }*/
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        transform.Translate(Vector3.right * (speed * Time.deltaTime * _axis.x));
        
    }
}
