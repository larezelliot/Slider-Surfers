using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public ForceMode forceMode = ForceMode.Force;
    public float forceMagnitude = 1;
    private Rigidbody rb = null;
    private Vector2 m_move = Vector2.zero;

    void OnMove(InputValue value)
    {
        m_move = value.Get<Vector2>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var move_vector = new Vector3(m_move.x, 0, 0);
        var move_force = move_vector * forceMagnitude * Time.deltaTime;

        rb.AddForce(move_force, forceMode);
    }
}
