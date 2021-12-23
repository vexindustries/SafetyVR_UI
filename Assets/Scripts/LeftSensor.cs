using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit;

public class LeftSensor : MonoBehaviour
{
    //JIB Body
    public GameObject JIB_Head_Prefab;
    public float xValue1 = -2.7f;
    public float yValue1 = 0.75f;
    public float zValue1 = 6.21f;
    public int JIB_Head_Count;

    // Slider
    public float timerLeft = 0.0f;
    public Slider LeftSlider;

    // Controller
    public GameObject leftController;

    // Hand Sensor Area
    public Rigidbody handSensorArea;

    //GRAB Script
    XRGrabInteractable script; //creates that script data type

    // Start is called before the first frame update
    void Start()
    {
        //Script to Turn On/Off
        script = GetComponent<XRGrabInteractable>();

        Debug.Log("ObjectManagerScriptLeft");
    }

    // Update is called once per frame
    void Update()
    {
        JIB_Head_Count = FindObjectsOfType<LeftControllerObject>().Length;

        if (JIB_Head_Count >= 1)
        {
            float leftHandInput = (handSensorArea.transform.position.x);
            Debug.Log(leftHandInput);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("LeftController"))
        {
            timerLeft += Time.deltaTime;
            Debug.Log(timerLeft);
            LeftSlider.value = timerLeft;
        }

        if (other.gameObject.CompareTag("LeftController") && (JIB_Head_Count <= 0) && (timerLeft >= 2.0f))
        {
            Instantiate(JIB_Head_Prefab, GenerateSpawnPosition1(), JIB_Head_Prefab.transform.rotation);
            script.enabled = true;
            Debug.Log("Test Collision Left");
        }

    }

    private Vector3 GenerateSpawnPosition1()
    {
        float spawnPosX = xValue1;
        float spawnPosY = yValue1;
        float spawnPosZ = zValue1;
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);
        return randomPos;
    }

}
