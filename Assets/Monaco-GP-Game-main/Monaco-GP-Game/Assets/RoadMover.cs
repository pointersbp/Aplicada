﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMover : MonoBehaviour
{
    public float speed;
    Vector2 offset; 
    
    
    private void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2 (0, Time.time * speed);
        GetComponent<Renderer> ().material.mainTextureOffset = offset;
    }
}
