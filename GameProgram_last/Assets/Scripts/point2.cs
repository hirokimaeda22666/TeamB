﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point2 : MonoBehaviour
{
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
        if (other.gameObject.tag == "Player")
        {
            Time_manager.start = true;
            Destroy(this.gameObject);
        }
    }

}
