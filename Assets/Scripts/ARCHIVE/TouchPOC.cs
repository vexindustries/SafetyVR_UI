using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPOC : MonoBehaviour
{
    public Rigidbody cylinderRB;

    // Start is called before the first frame update
    void Start()
    {
        cylinderRB = GetComponent<Rigidbody>();
        Debug.Log("Touch Object Initiated: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
            Debug.Log(gameObject.name + " touched " + other.gameObject.name);
    }



}
