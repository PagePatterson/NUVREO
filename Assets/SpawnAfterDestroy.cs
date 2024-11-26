using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnAfterDestroy : MonoBehaviour
{
    private Transform spawnPoint;
    void Start()
    {
        spawnPoint = this.transform;
    }

    private void OnDestroy()
    {
        Instantiate(this, spawnPoint);
    }
}