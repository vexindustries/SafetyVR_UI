using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    // public variables
    public float speed = 10;
    public float xRange = 2;

    // Start is called before the first frame update
    void Start()
    {
        BoxCollider GameCollR = GetComponentInChildren<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // On Collision, Trigger doors to open
    private void OnTriggerEnter(Collider other)
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    private void OnTriggerExit(Collider other)
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
