using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    public GameObject bulletPrefab;

    public bool isFrist = false;

    private bool isCreate = false;

    //public float spawnRate = 1f;
    //private float timeAfterSpawn;

    // Start is called before the first frame update
    void Start()
    {
        if (isFrist)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }

        //timeAfterSpawn = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //timeAfterSpawn += Time.deltaTime;

        //if (timeAfterSpawn >= spawnRate)
        //{
        //    timeAfterSpawn = 0f;

        //    //GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        //    // 총알은 직선으로만 나가면됨 (위 아래로) 
        //    // bullet.transform.LookAt();

        //    Instantiate(bulletPrefab, transform.position, transform.rotation);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Bullet" && isCreate == false)
        {
            isCreate = true;
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            Destroy(other.gameObject);
        }

        else if ( other.tag == "Bullet" && isCreate == true)
        {
            isCreate = false;
        }


    }
    /*
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Bullet" && isCreate == true)
        {
            isCreate = false;
        }
    }
    */





}
