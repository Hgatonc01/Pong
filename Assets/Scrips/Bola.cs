using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bola : MonoBehaviour
{

    public float speed = 20;
    public Rigidbody2D rb;
    public AudioClip choqueBola;
    private Vector2 startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        Launch();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        AudioSource.PlayClipAtPoint(choqueBola,
            transform.position, 1);
    }

        public void Reset()
    {
        transform.position = startPos;
        rb.velocity = Vector2.zero;
        Launch();
    }

    public void Launch()
    {
        float x = UnityEngine.Random.Range(0,2) == 0 ? -1 : 1;
        float y = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(speed*x, speed*y);
    }

   
}
