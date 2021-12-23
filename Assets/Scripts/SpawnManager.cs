using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject jibPrefab;
    public float xValue1 = -2.7f;
    public float yValue1 = 0.75f;
    public float zValue1 = 6.21f;
    public int jibCount;

    public GameObject testCubePrefab;
    public float xValue2 = -2.7f;
    public float yValue2 = 0.75f;
    public float zValue2 = 6.21f;
    public int testCubeCount;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(jibPrefab, GenerateSpawnPosition1(), jibPrefab.transform.rotation);

        Instantiate(testCubePrefab, GenerateSpawnPosition2(), testCubePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        jibCount = FindObjectsOfType<JackInTheBox>().Length;
        testCubeCount = FindObjectsOfType<TestingCube>().Length;

        if (jibCount == 0)
        {
            Instantiate(jibPrefab, GenerateSpawnPosition1(), jibPrefab.transform.rotation);
        }

        if (testCubeCount == 0)
        {
            Instantiate(testCubePrefab, GenerateSpawnPosition2(), testCubePrefab.transform.rotation);
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

    private Vector3 GenerateSpawnPosition2()
    {
        float spawnPosX = xValue2;
        float spawnPosY = yValue2;
        float spawnPosZ = zValue2;
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);
        return randomPos;
    }
}
