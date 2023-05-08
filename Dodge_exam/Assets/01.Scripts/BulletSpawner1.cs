using UnityEngine;

public class BulletSpawner1 : MonoBehaviour
{

    public GameObject bulletPrefab;


    public float spawnRate = 2f;
    private float timeAfterSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;

        
    }

    // Update is called once per frame
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
