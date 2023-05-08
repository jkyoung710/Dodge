using UnityEngine;

public class HealBullet : MonoBehaviour
{

    public float speed = 9f;
    private Rigidbody bulletRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();

        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 5f);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                // �� �κп� Die �޼��� ���� �ٸ� �޼��� ��������� �����ؾ��� 

                playerController.Alive();

                Destroy(gameObject);


            }

        }

    }


}
