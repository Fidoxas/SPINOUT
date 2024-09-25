using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMoover : MonoBehaviour
{
    private Rigidbody rb;
    private int _minSpeed = 50;
    private int maxSpeed = 1000;
    public int speed;


    private void OnEnable()
    {
        speed = Random.Range(_minSpeed, maxSpeed);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.back * speed);
        Debug.Log("pushed " + speed *50);
    }
}
