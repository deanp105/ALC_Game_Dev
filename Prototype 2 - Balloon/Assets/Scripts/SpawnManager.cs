using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs; //array to store balloon prefabs
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    public float xRange = 10.0f;
    public float yPos = -1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }


    void SpawnRandomBalloon()
    {
        // get a random position on the x axis
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), yPos, 0);

        // pick a random balloon from the balloon array
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);

        // spawn random balloon at the spawn position
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }

}
