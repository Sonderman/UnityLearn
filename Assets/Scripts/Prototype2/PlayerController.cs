using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float speed = 1f;
    [SerializeField] public float turnSpeed = 1f;
    private Vector2 _axis;
    
    
    public void OnMove(InputValue value)
    {
        _axis = value.Get<Vector2>();
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime * _axis.y));
        transform.Rotate(Vector3.up,(turnSpeed * Time.deltaTime * _axis.x));
    }
}