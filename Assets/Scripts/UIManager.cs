using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject gamooverPanel;
    // Start is called before the first frame update
    void Awake()
    {
        gamooverPanel.SetActive(false);
    }

    public void OnGameOverPanel()
    {
        gamooverPanel.SetActive(true);
    }
}
