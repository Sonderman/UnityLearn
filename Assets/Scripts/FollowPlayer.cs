
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
