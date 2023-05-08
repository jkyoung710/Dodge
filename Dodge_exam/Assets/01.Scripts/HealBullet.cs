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
                // 이 부분에 Die 메서드 말고 다른 메서드 만든다음에 선언해야함 

                playerController.Alive();

                Destroy(gameObject);


            }

        }

    }


}
