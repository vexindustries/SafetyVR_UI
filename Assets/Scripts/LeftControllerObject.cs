using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftControllerObject : MonoBehaviour
{
    public float speed  = 0.001f;
    public Rigidbody headRb;
    public GameObject leftObject;
    public int JIB_Head_Count;
    public Vector3 leftObjectPosition;

    // Start is called before the first frame update
    void Start()
    {
        headRb = GetComponent<Rigidbody>();
        leftObject = GameObject.Find("LeftHandCylinder");
    }

    // Update is called once per frame
    void Update()
    {
        JIB_Head_Count = FindObjectsOfType<LeftControllerObject>().Length;

        if (JIB_Head_Count >= 1)
        {
            float moveDirection = (leftObject.transform.position.x - transform.position.x);
            transform.Translate(0, 0, moveDirection);
            Debug.Log("LC" + moveDirection);
        }
    }
}
