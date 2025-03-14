﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    public GameObject gamooverPanel;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    void OnEnable()
    {
        gamooverPanel.SetActive(false);
        DestroyOutOfBoundsX.OnGameover += OnGameover;
    }
    void OnDisable()
    {
        DestroyOutOfBoundsX.OnGameover -= OnGameover;
    }
    void Start()
    {
        spawnInterval = Random.Range(3.0f, 5.0f);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int idx = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[idx], spawnPos, ballPrefabs[idx].transform.rotation);
    }

    private void OnGameover()
    {
        gamooverPanel.SetActive(true);
        CancelInvoke(nameof(SpawnRandomBall));
    }

}
