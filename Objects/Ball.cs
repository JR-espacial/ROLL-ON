using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody rb;
    float horizontal_input, magnitude;
    Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Pelota";
        rb = GetComponent<Rigidbody>();
        moveDirection = new Vector3(0, 0, 2);
        magnitude = 20f;
        GetComponent<Rigidbody>().AddForce( moveDirection * magnitude,ForceMode.Impulse);
    }

    // fixed update
    void FixedUpdate()
    {
        rb.AddForce( 0, 0, 1.25f * Time.deltaTime);
        rb.velocity = 10 * rb.velocity.normalized;
        //rb.AddRelativeForce (Vector3.forward * 100 - rb.velocity);
        horizontal_input = Input.GetAxis("Horizontal");
        Vector3 new_position = new Vector3(0.4f, rb.position.y, rb.position.z);

        if (horizontal_input < 0)
        {
            new_position.x *= -1;
        }

        if (horizontal_input != 0)
        {
            new_position.x = rb.position.x + new_position.x;
            rb.MovePosition(new_position);
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log (collision.gameObject.tag);
        if (collision.gameObject.CompareTag ("Obstaculo"))
        {
            Destroy(gameObject);
            //GameManager.GetComponent<Game_Manager>().EndGame();
        }
    }
       // Update is called once per frame
    void Update()
    {
        
    }
}
