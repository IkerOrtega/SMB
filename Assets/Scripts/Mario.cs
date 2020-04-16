using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public float speed;
    public Vector2 direction;
    public int maxSpeed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
        direction = Vector2.zero;
        rb = GetComponent<Rigidbody2D>();

        maxSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0 && speed <= maxSpeed)
        {
            speed += speed * Time.deltaTime;
            direction = Vector2.right;
            rb.velocity = direction * speed;
        }
        else if (Input.GetAxis("Horizontal") < 0 && speed <= maxSpeed)
        {
            speed += speed * Time.deltaTime;
            direction = Vector2.left;
            rb.velocity = direction * speed;
        }
    }
}
