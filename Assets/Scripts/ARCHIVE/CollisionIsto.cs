using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit;

public class CollisionIsto : MonoBehaviour
{
    TestScript script; //creates that script data type

    // Start is called before the first frame update
    void Start()
    {
        script = GetComponent<TestScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Test") && script.enabled == true)
        {
            Debug.Log("TEST COLLISION IF");
            script.enabled = false;
        }

        else if (other.gameObject.CompareTag("Test") && script.enabled == false)
        {
            Debug.Log("TEST COLLISION ELSE");
            script.enabled = true;
        }

    }
}
