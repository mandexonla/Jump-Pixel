using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float FollowSpeed = 2f;
    [SerializeField] private float Ypos = 1f;
    [SerializeField] private Transform target;
    //[SerializeField] private Camera MainCamera;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPo = new Vector3(target.position.x, target.position.y + Ypos, -10f);
        transform.position = Vector3.Slerp(transform.position, newPo, FollowSpeed * Time.deltaTime);
    }
}