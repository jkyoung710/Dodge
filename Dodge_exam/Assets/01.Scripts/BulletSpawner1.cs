using UnityEngine;

public class BulletSpawner1 : MonoBehaviour
{

    public GameObject bulletPrefab;


    public float spawnRate = 2f;
    private float timeAfterSpawn;

    void Start()
    {
        timeAfterSpawn = 0f;

        
    }

    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            //GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // 총알은 직선으로만 나가면됨 (위 아래로) 
            // bullet.transform.LookAt();

            Instantiate(bulletPrefab, transform.position, transform.rotation);

        }

    }
}
