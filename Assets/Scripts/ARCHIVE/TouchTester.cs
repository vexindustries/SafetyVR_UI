using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTester : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput);

    }
}
