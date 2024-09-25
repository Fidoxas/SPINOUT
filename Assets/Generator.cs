using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;
    [SerializeField] float timeBetweenSpawns;

    private void Start()
    {
        StartCoroutine(GenerateObstacles());
    }

    IEnumerator GenerateObstacles()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, prefabs.Length);

            Instantiate(prefabs[randomIndex], transform.position, Random.rotation);

            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }
}
