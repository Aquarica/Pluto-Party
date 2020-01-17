using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContoller : MonoBehaviour
{


    public float speed;


    //public GameObject player;
    private Rigidbody2D rb2d;


    void Start()
    //varible set
    {
        rb2d = GetComponent<Rigidbody2D>();

    }


    void FixedUpdate()
    //Players Movement
    {
        float moveHorizonal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizonal, moveVertical);
        rb2d.AddForce(movement * speed);

        if (Input.GetKey("escape"))
            Application.Quit();
    }



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb2d.AddForce(new Vector2(0, 3), ForceMode2D.Impulse);
            }
        }
    }


}
