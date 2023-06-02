using UnityEngine;

public class HealBulletSpawner : MonoBehaviour
{

    public GameObject healBulletPrefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;


    void Start()
    {
        timeAfterSpawn = 0f;

        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        target = FindObjectOfType<PlayerController>().transform;

        
    }

    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if ( timeAfterSpawn >= spawnRate)
        {

            timeAfterSpawn = 0f;

            Instantiate(healBulletPrefab, transform.position, transform.rotation);


            // bullet.transform.LookAt(target);

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        }

                
    }
}
