using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public float Kecepatanbola;

    public bool player1Start = true;

    private Text speedtext;
    private float _Tambahkecepatan = 5.0f;
    private int _Pantulan = 0;
    private float _maxTambahKecepatan = 20.0f;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    private void RestartBall()
    {
        _rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
    }

    public IEnumerator Launch()
    {
        RestartBall();
        _Pantulan = 0;
        yield return new WaitForSeconds(1);
        MoveBall(new Vector2(-1, 0));

        if (player1Start == true)
        {
            MoveBall(new Vector2(-1, 0));
        }
        else
        {
            MoveBall(new Vector2(1, 0));
        }
    }
    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float ballspeed = Kecepatanbola + _Pantulan * _Tambahkecepatan;

        _rb.velocity = direction * ballspeed;
    }

    public void IncreasePantulan()
    {
        if(_Pantulan * _Tambahkecepatan < _maxTambahKecepatan)
        {
            _Pantulan++;
        }
    }

    void Update()
    {
    
    }



}
