using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleButtonEvents : MonoBehaviour
{
    public GameObject spawnableObject;
    public Transform spawnTransform;
    public void SpawnObject()
    {
        Instantiate(spawnableObject, spawnTransform);
    }
}
