using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Raqueta : MonoBehaviour
{
    public bool player1;
    public float speed = 10;
    public Rigidbody2D rb;

    private float move;
    private Vector2 startPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (player1)
        {
            move = Input.GetAxisRaw("Vertical2");
        }
        else
        {
            move = Input.GetAxisRaw("Vertical");
        }

        rb.velocity = new Vector2(rb.velocity.x, move*speed);
    }


    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }
}
