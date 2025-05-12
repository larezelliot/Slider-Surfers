using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public ForceMode forceMode = ForceMode.Force;

    [SerializeField]
    public float forceMagnitude = 1;

    private Rigidbody rb = null;

    private Vector2 m_move = Vector2.zero;

    void OnMove(InputValue value)
    {
        m_move = value.Get<Vector2>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var move_vector = new Vector3(m_move.x, 0, m_move.y);
        var move_force = move_vector * forceMagnitude;

        rb.AddForce(move_force, forceMode);
        Debug.Log("Moving: " + move_vector);
    }
}
