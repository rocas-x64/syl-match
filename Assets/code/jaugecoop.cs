using UnityEngine;

public class jaugecoop : MonoBehaviour
{

    public float speed = 4f;
    public float distance = 20f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(startPosition.x + movement, startPosition.y, startPosition.z);
    }
}
