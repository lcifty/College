﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doug : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Counter.Score += 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
