﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FackingWall : MonoBehaviour
{
    [SerializeField]
    public GameObject DestroyWall;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DestroyWall")
        {
            Destroy(DestroyWall);

        }
    }
}
