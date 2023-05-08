using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody bulletRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();

        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null)
            {
                playerController.Die();
            }

        }

    }


}
