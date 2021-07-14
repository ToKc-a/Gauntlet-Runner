using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerUpPrefab;
    public GameObject obstaclePrefab;
    public float spawnCycle = .5f;

    GameManager manager;
    float elapsedTime;
    bool spawnPowerUp = true;

    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnCycle)
        {
            GameObject temp;
            if (spawnPowerUp)
                temp = Instantiate(powerUpPrefab) as GameObject;
            else
                temp = Instantiate(obstaclePrefab) as GameObject;

            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            temp.transform.position = position;
            Coliidable col = temp.GetComponent<Coliidable>();
            col.manager = manager;

            elapsedTime = 0;
            spawnPowerUp = !spawnPowerUp;
        }
    }
}
