using UnityEngine;
using UnityEngine.InputSystem;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float turnSpeed = 50f;
    [SerializeField] private float propellerSpeed = 100f;
    [SerializeField] private GameObject propeller;
    private Vector2 _axis;
    
    
    public void OnMove(InputValue value)
    {
        _axis = value.Get<Vector2>();
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        transform.Rotate(Vector3.right,turnSpeed * Time.deltaTime * _axis.x);
        RotatePropeller();
    }

    private void RotatePropeller()
    {
        if (propeller != null)
        {
            propeller.transform.Rotate(Vector3.forward,Time.deltaTime*propellerSpeed);
        }
    }
}
