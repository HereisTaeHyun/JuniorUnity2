using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    UIManager uIManager;
    private float spawnRangeX = 15.0f;
    private float spawnPointZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawnDelay = 2.0f;
    private void OnEnable()
    {
        DestroyOutOfBounds.OnGameOver += OnGameOverPanel;
    }
    private void OnDisable()
    {
        
    }

    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, spawnDelay);
    }

    private void SpawnRandomAnimal()
    {
        int idx = Random.Range(0, animals.Length);
        float spawnPointX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPoint = new Vector3(spawnPointX, 0, spawnPointZ);
        Instantiate(animals[idx], spawnPoint, animals[idx].transform.rotation);
    }
    
    public GameObject gamooverPanel;
    public void OnGameOverPanel()
    {
        gamooverPanel.SetActive(true);
        CancelInvoke(nameof(SpawnRandomAnimal));
    }
}
