using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    public GameObject bulletPrefab;

    public bool isFrist = false;

    private bool isCreate = false;


    // ------------------------

    //private MeshRenderer[] mesh_r;
    //private BoxCollider[] box_c;
    //private float liveCount;



    void Start()
    {
        if (isFrist)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }

        // ---------------------------

        //mesh_r = gameObject.GetComponentsInChildren<MeshRenderer>();
        // box_c = gameObject.GetComponentsInChildren<BoxCollider>();

    }

    void Update()
    {
        //liveCount += Time.deltaTime;
        //if (liveCount > 2f)
        //{
        //    foreach (MeshRenderer mrr in mesh_r)
        //    {
        //        mrr.enabled = true;
        //    }
        //}

        //if (liveCount > 4f)
        //{
        //    foreach (BoxCollider bxc in box_c)
        //    {
        //        bxc.enabled = true;
        //    }
        //}


        // �̺κ��� if �� �ƴ϶� �ٸ� �ڵ带 ����ؼ� ��Ȳ�� �°� Ȱ��ȭ ��Ȱ��ȭ �Ǿ��� 

        //if (GameManager.surviveTime >= 6f)
        //{
            


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


}
