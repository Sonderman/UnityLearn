using UnityEngine;

public class MoveForward : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float bound;

    private void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        if (transform.position.z > bound)
        {
            Destroy(gameObject);
        }else if (transform.position.z < -bound)
        {
            Destroy(gameObject);
        }
    }
}
