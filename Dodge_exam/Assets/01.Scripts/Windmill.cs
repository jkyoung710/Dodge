using UnityEngine;

public class Windmill : MonoBehaviour
{
    private MeshRenderer[] mesh_r;
    private SphereCollider [] box_c;
    private float liveCount;
    //2. public GameObject[] cube = new GameObject[3];

    private float rotationSpeed = 60f;



    void Start()
    {

        mesh_r = gameObject.GetComponentsInChildren<MeshRenderer>();
        box_c = gameObject.GetComponentsInChildren<SphereCollider>();
    }
    // GetComponent<BoxCollider>();
    void Update()
    {
        liveCount += Time.deltaTime;

        if (true)
        {

            foreach (MeshRenderer mrr in mesh_r)
            {
                mrr.enabled = true;

            }

            if (true)

            foreach(SphereCollider bxo in box_c)
            {
                bxo.enabled = true;
            }



        }



        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);






    }
}
