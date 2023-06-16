using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private float xPos;
    private float yPos;

    void Start()
    {
        PointSystem();
    }

    void Update()
    {
        xPos = Random.Range(-20.8f, 20.9f);
        yPos = Random.Range(-8.3f , 8.4f);
    }

    public void PointSystem()
    {
        transform.position = new Vector3(Mathf.Round(xPos), Mathf.Round(yPos), 0f);
    }
}
