using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 20;

    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /* var input = Input.GetAxis("Horizontal");
         var input2 = Input.GetAxis("Vertical");

         Vector2 position = transform.position;
         position.x += speed * Time.deltaTime * input;
         position.y += speed * Time.deltaTime * input2;
         transform.position = position;*/

        float input = Input.GetAxis("Horizontal") * speed;
        float input2 = Input.GetAxis("Vertical") *speed;

        //left right
        if (Input.GetKey(KeyCode.D)) 
        {
            rigidbody.AddForce(Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(-Vector2.right * speed);
        }

        //up down
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(Vector2.up * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(-Vector2.up * speed);
        }

    }
}
