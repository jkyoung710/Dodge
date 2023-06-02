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

    //  플레이어 이동에 대한 코드
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


    // 플레이어 오브젝트 비활성화
    public void Die()
    {
        gameObject.SetActive(false);

        // 씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기
        //  GameManager gameManager = FindObjectOfType<GameManager>();
        //  gameManager.DeadCount();
        // 가져온 GameManager 오브젝트의 EndGame() 메서드 실행
        //   gameManager.EndGame();
      
        GameManager.Instance.EndGame();
       

    }


    public void Alive()
    {
        livecount = 10f;

    }

    // 컨 kc   컨 ku

    // Die 메서드 말고 HealBullet 과 관련된 메서드 선언해야함 
    // 메서드 기능 > 사라지는데 걸리는 시간을 10으로 리셋 
    // 총알 사라지는 시간을 줄이는데  a-- 사용해서 1초씩 줄인다. 
    // 총알을 맞으면 a 를 10으로 초기화 
    // a 의값이 0 이 되면 플레이어 사망 


}
