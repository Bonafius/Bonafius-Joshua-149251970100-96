using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Ballspeed;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    public IEnumerator Launch()
    {
        yield return new WaitForSeconds(1);
        MoveBall(new Vector2(-1, 0));
    }
    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float ballspeed = Ballspeed;

        _rb.velocity = direction * ballspeed;
    }

    void Update()
    {
        
    }



}
