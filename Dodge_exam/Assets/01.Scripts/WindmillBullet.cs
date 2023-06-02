using UnityEngine;

public class WindmillBullet : MonoBehaviour
{

    private Rigidbody bulletRigidbody;


    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.Die();
            }

        }

    }



}
