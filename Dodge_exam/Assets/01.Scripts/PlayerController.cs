using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 15f;

    public float livecount = 10f;


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
                     
    }

    //  �÷��̾� �̵��� ���� �ڵ�
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        playerRigidbody.velocity = newVelocity;


        livecount -= Time.deltaTime;

        if (livecount <= 0)
        {

            gameObject.SetActive(false);

            GameManager gameManager = FindObjectOfType<GameManager>();

            gameManager.EndGame();
            

        }


    }


    // �÷��̾� ������Ʈ ��Ȱ��ȭ
    public void Die()
    {
        gameObject.SetActive(false);

        // ���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        //  GameManager gameManager = FindObjectOfType<GameManager>();
        //  gameManager.DeadCount();
        // ������ GameManager ������Ʈ�� EndGame() �޼��� ����
        //   gameManager.EndGame();
      
        GameManager.Instance.EndGame();
       

    }


    public void Alive()
    {
        livecount = 10f;

    }

    // �� kc   �� ku

    // Die �޼��� ���� HealBullet �� ���õ� �޼��� �����ؾ��� 
    // �޼��� ��� > ������µ� �ɸ��� �ð��� 10���� ���� 
    // �Ѿ� ������� �ð��� ���̴µ�  a-- ����ؼ� 1�ʾ� ���δ�. 
    // �Ѿ��� ������ a �� 10���� �ʱ�ȭ 
    // a �ǰ��� 0 �� �Ǹ� �÷��̾� ��� 


}
