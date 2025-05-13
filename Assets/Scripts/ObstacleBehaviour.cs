using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    public float speed = 1;
    private Rigidbody rb = null;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var velocity = new Vector3(0, 0, -speed) * Time.deltaTime;
        rb.linearVelocity = velocity;
    }
}
