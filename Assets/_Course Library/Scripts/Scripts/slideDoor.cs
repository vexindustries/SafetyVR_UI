using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideDoor : MonoBehaviour
{
    public GameObject moveDoor;

    public float maxOpen = 15;
    public float maxClose = 0;

    public float movementSpeed = 5;

    bool playerIsHere;
    bool opening;

    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
        opening = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere)
        {
            if (moveDoor.transform.position.x < maxOpen)
            {
                moveDoor.transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);
            }
        }
        else
        {
            if(moveDoor.transform.position.x > maxClose)
            {
                moveDoor.transform.Translate(-movementSpeed * Time.deltaTime, 0f, 0f);
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            playerIsHere = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = false;
        }
    }
}
