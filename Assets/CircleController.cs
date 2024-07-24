using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{   //Universal Variables
    float speed = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //Is player pressing D key
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * speed * Time.deltaTime);
        }

        //Is player pressing A key
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * speed * Time.deltaTime);
        }

        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        //Is player pressing W key
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * speed);
        }
    }
}
