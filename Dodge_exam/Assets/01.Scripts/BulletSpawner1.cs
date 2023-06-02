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

            // �Ѿ��� �������θ� ������� (�� �Ʒ���) 
            // bullet.transform.LookAt();

            Instantiate(bulletPrefab, transform.position, transform.rotation);

        }

    }
}
