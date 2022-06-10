using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kecepatan : MonoBehaviour
{
    public Transform BallMovement;
    public Text Kecepatantext;

    private void Update()
    {
        Kecepatantext.text = BallMovement.ToString();
    }
}
