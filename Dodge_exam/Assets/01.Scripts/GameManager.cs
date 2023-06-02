using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;
    public Text deadText;

    private Level1 level1;
    private Level2 level2;
    private Level3 level3;

    Transform chil1;
    Transform chil2;
    Transform chil3;

    public static float surviveTime;
    private bool isGameover;
    private static int deadCount;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        surviveTime = 0;
        isGameover = false;
        deadText.text = "Dead :" + deadCount;

        level1 = FindObjectOfType<Level1>();
        chil1 = level1.transform.GetChild(0);
        level2 = FindObjectOfType<Level2>();
        chil2 = level2.transform.GetChild(0);
        level3 = FindObjectOfType<Level3>();
        chil3 = level3.transform.GetChild(0);


        if (surviveTime >= 10f)
        {
            chil2.rotation = Quaternion.Euler(0, 0, 0);
            // 이 코딩문은 비활성화된 물체의 로테이션은 비활성되는 순간의 로테이션 값을 가진 체로 존재
            // ex) rotation (0,48,0)에서 비활성화시 재활성화시  rotation (0,48,0)에서 돌기 시작. 이미 48도 회전상태로 등장함
            // 해당 오브젝트를 활성화 시 원점에서 회전 시작을 원한다면 사용
                        
        }

        // Invoke("testtime", 3f);

    }
    // -------------------------------------  invoke 사용 부분 
    //public void testtime()
    //{
    //    Debug.Log("3초지남");
    //}

    void Update()
    {
        

        if (!isGameover)
        {
            // 생존시간 갱신
            surviveTime += Time.deltaTime;
            // 갱신한 생존 시간을 timeText 텍스트 컴포넌트를 이용해 표시
            timeText.text = "Time :" + (int)surviveTime;

        }

        else
        {
            
            // 게임오버인 상태에서 R 키를 누른 경우
            if (Input.GetKeyDown(KeyCode.R))
            {
                
                // SampleScene 씬을 로드
                SceneManager.LoadScene("SampleScene");

            }

        }


        if (surviveTime >= 10f) 
        {
            chil1.gameObject.SetActive(false);
        }


        if (surviveTime >= 10f)
        {
            chil2.gameObject.SetActive(true);
        }

        // bool 값(예시 : isPhase03 == true)이 참으로 if문을 실행하여 어제 언급했던 bool 변수를 이용한 페이즈 변경을 이용할 것을 권장

        if (surviveTime >= 20f) 
        {
            chil2.gameObject.SetActive(false);
        }

        // 페이즈를 넘어가기전 bool 값을 거짓으로 하여 오브젝트를 비활성화

        if (surviveTime >= 20f)
        {
            chil3.gameObject.SetActive(true);
        }


        if (surviveTime >= 30f)
        {
            // chil3.gameObject.SetActive(false);
        }


    }


    // 현재 게임을 게임오버 상태로 변경하는 메서드
    public void EndGame()
    {
        // 현재 상태를 게임오버 상태로 전환
        isGameover = true;
        // 게임오버 텍스트 게임 오브젝트를 활성화
        gameoverText.SetActive(true);
        //죽엇을때 데드카운트 표시
        deadCount++;
        deadText.text = "Dead :" + deadCount;



        // BestTime 키로 저장된 이전까지의 최고 기록 가져오기
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // 이전까지의 최고 기록보다 현재 생존 시간이 더 크다면
        if (surviveTime > bestTime)
        {
            // 최고 기록 값을 현재 생존 시간 값으로 변경
            bestTime = surviveTime;
            // 변경된 최고 기록을 BestTime 키로 저장
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        // 최고 기록을 recordText 텍스트 컴포넌트를 이용해 표시
        recordText.text = "BestTime: " + (int)bestTime;

    }


//    무지개 색으로 단계를 나타낸다.
//1단계 redspawner 지그재그                      v 
//2단계 orangespawner 풍차 (한방향)              v
//3단계 yellowspawner 지그재그 (가로방향 추가)   v
//4단계 greenspawner 풍차 (4바퀴 돌고 반대 반복)
//5단계 bluespawner 지그재그(대각방향 추가) (튕기기)      
//6단계 Indigospawner 풍차(한방향, 90회전 4초정지)
//7단계 violetspawner 유도총알

//시간별로 단계를 만든다 30초를 버티면 다음 스테이지로 이동
//생존시간과 힐총알은 10초로 고정







}
