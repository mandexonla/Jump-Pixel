using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float Ypos = 1f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPo = new Vector3(target.position.x, target.position.y + Ypos, -10f);
        transform.position = Vector3.Slerp(transform.position, newPo, FollowSpeed * Time.deltaTime);
    }
}