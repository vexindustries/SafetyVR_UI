using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingCube : MonoBehaviour
{
    private Rigidbody glassCubeRb;

    // Start is called before the first frame update
    void Start()
    {
        glassCubeRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}
