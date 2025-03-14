using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    public UIManager uIManager;
    public delegate void GameOverHandler();
    public static event GameOverHandler OnGameOver;

    void Awake()
    {
        uIManager = GameObject.FindGameObjectWithTag("UIMANAGER").GetComponent<UIManager>();
    }

    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            OnGameOver();
            uIManager.OnGameOverPanel();
        }
    }
}
