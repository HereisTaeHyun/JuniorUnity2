using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float coolTime = 0.3f;
    private float leftTime;
    private bool canGo = true;

    // Update is called once per frame
    void Update()
    {
        if(leftTime > 0)
        {
            leftTime -= Time.deltaTime;
            if(leftTime <= 0)
            {
                canGo = true;
            }
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canGo == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canGo = false;
            leftTime = coolTime;
        }
    }
}
