using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float racketSpeed;

    private Rigidbody2D _rb;
    private Vector2 _racketDirection;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        _racketDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        _rb.velocity = _racketDirection * racketSpeed;
    }
}
