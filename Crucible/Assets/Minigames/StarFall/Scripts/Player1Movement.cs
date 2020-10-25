﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{   
    public float speed =  10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("P1_Horizontal"), Input.GetAxis("P1_Vertical"), 0f);
        transform.position += movement * Time.deltaTime * speed;
    }
}
