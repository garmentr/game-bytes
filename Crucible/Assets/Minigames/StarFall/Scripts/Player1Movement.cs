﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{   
    public float speed =  10f;
    public float jumpHeight = 5f;
    public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("P1_Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
    }

    void Jump()
    {
        if(Input.GetButtonDown("P1_Vertical") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if(collision.collider.tag == "star")
        {
            getPoint(collision.collider.gameObject);
        }
    }

    void getPoint(GameObject star)
    {
        Destroy(star);
        MinigameController.Instance.AddScore(1, 1);
    }

}
