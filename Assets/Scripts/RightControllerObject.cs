using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightControllerObject : MonoBehaviour
{
    public float speed = 0.001f;
    public Rigidbody bodyRb;
    public GameObject rightObject;
    public int JIB_Body_Count;
    public Vector3 rightObjectPosition;

    // Start is called before the first frame update
    void Start()
    {
        bodyRb = GetComponent<Rigidbody>();
        rightObject = GameObject.Find("RightHandCylinder");
    }

    // Update is called once per frame
    void Update()
    {
        JIB_Body_Count = FindObjectsOfType<RightControllerObject>().Length;

        if (JIB_Body_Count >= 1)
        {
            float moveDirection = (rightObject.transform.position.x - transform.position.x);
            transform.Translate(0, 0, moveDirection);
            Debug.Log("RC" + moveDirection);
        }
    }
}
