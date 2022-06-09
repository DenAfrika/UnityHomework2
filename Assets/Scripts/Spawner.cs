using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject NPS;
    [SerializeField] GameObject spawnPoint;
    [SerializeField] float startTimeBtwSpawn;

    private float timeBtwSpawn;
    // Start is called before the first frame update
    void Start()
    {
        timeBtwSpawn = startTimeBtwSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            Instantiate(NPS, spawnPoint.transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
