using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coliidable : MonoBehaviour
{
    public GameManager manager;
    public float moveSpeed = 20f;
    public float timeAmount = 1.5f;

    void Update()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        manager.AdjustTime(timeAmount);
        Destroy(gameObject);
    }
}
