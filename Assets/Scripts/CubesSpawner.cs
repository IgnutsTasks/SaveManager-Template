using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] cubes;
    [SerializeField] private Transform spawnPoint;

    public void SpawnCube()
    {
        Instantiate(cubes[Random.Range(0, cubes.Length)], spawnPoint.position, Quaternion.identity);
    }
}
