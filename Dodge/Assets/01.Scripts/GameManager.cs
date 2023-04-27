using UnityEngine;
using UnityEngine.UI;               //  UI관련 라이브러리
using UnityEngine.SceneManagement;  // 씬 관리 관련 라이브러리

public class GameManager : MonoBehaviour
{

    public GameObject gameoverText;   //  게임오버 시 활성화할 텍스트 게임 오브젝트
    // 직업 명시하는 방법도 있다.
    // 장단점이 있다.
    // 딱 한번만 사용할 경우 직접 명시하는게 좋다.
    // 자주 사용한다면 라이브러리를 사용하겠다고 명시를 하고 공간확보가 되서 빠르다..
    public Text timeText;             //  생존 시간을 표시할 텍스트 컴포넌트
    public Text recordText;           //  최고 기록을 표시할 텍스트 컴포넌트

    private float surviveTime;        //  생존 시간
    private bool isGameover;          //  게임 오버 상태


    // Start is called before the first frame update
    void Start()
    {
        // 생존 시간과 게임오버 상태 초기화
        surviveTime = 0;
        isGameover = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        
        // 게임오버가 아닌 동안
        if (!isGameover)
        {
            // 생존 시간 갱신
            surviveTime += Time.deltaTime;

            // 갱신한 생존 시간을  timeText 텍스트 컴포넌트를 이용해 표시
            timeText.text = "Time:" + (int)surviveTime;
        }

        else
        {
            // 게임오버 상태에서 R키를 누른 경우
            if (Input.GetKeyDown(KeyCode.R))
            {

                // SampleScene 씬을 로드
                SceneManager.LoadScene("SampleScene");
                // SceneManager.LoadScene(0);  >>>>>>>>  익덱스 값으로 로드하는 방식
                // SampleScene을 등록해줘야 한다. 

            }
        }


    }

    // 현재 게임을 게임오버 상태로 변경하는 메서드
    public void EndGame()
    {
        // 현재 상태를 게임오버 상태로 전한
        isGameover = true;

        // 게임오버 텍스트 게임 오브젝트를 활성화
        gameoverText.SetActive(true);


    }


}
