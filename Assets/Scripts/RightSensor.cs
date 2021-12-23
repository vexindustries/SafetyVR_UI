using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit;

public class RightSensor : MonoBehaviour
{
    //JIB Head
    public GameObject JIB_Body_Prefab;
    public float xValue2 = -2.7f;
    public float yValue2 = 0.75f;
    public float zValue2 = 6.21f;
    public int JIB_Body_Count;

    // Slider
    public float rightTimer = 0.0f;
    public Slider rightSlider;

    // Controller
    public GameObject rightcontroller;

    // Hand Sensor Area
    public GameObject handSensorArea;

    //GRAB Script
    XRGrabInteractable script; //creates that script data type

    // Start is called before the first frame update
    void Start()
    {
        //Script to Turn On/Off
        script = GetComponent<XRGrabInteractable>();

        Debug.Log("ObjectManagerScriptRight");
    }

    // Update is called once per frame
    void Update()
    {
        JIB_Body_Count = FindObjectsOfType<RightControllerObject>().Length;

        if (JIB_Body_Count >= 1)
        {
            float rightHandInput = (handSensorArea.transform.position.x);
            Debug.Log(rightHandInput);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("RightController"))
        {
            rightTimer += Time.deltaTime;
            Debug.Log(rightTimer);
            rightSlider.value = rightTimer;
        }

        if (other.gameObject.CompareTag("RightController") && (JIB_Body_Count <= 0) && (rightTimer >= 2.0f))
        {
            Instantiate(JIB_Body_Prefab, GenerateSpawnPosition1(), JIB_Body_Prefab.transform.rotation);
            script.enabled = true;
            Debug.Log("Test Collision Right");
        }

    }

    private Vector3 GenerateSpawnPosition1()
    {
        float spawnPosX = xValue2;
        float spawnPosY = yValue2;
        float spawnPosZ = zValue2;
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);
        return randomPos;
    }

}
