using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private int xyz;
    private float r, g, b, a;
    public float speed;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * Random.Range(1.3f, 5.0f);
        
        Material material = Renderer.material;

        speed = Random.Range(100.0f, 500.0f);

        // r = 0.5f;
        // g = 1.0f;
        // b = 0.3f;
        // a = 0.7f;

        r = Random.Range(0, 1.0f);
        g = Random.Range(0, 1.0f);
        b = Random.Range(0, 1.0f);
        a = Random.Range(0, 1.0f);
        
        material.color = new Color(r, g, b, a);
    }
    
    void Update()
    {
        float x = 0.0f, y = 0.0f, z = 0.0f;
        switch(xyz)
        {
            case 0:
                x = speed * Time.deltaTime;
                break;
            case 1:
                x = speed * Time.deltaTime;
                break;
            case 2:
                x = speed * Time.deltaTime;
                break;
        }
        transform.Rotate(x, y, z);
    }
}
