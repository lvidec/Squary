using UnityEngine;

public class FollowSquary : MonoBehaviour
{

    public Transform squary;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = squary.position + offset;
    }
}
