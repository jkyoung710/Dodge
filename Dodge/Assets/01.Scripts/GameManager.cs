using UnityEngine;
using UnityEngine.UI;               //  UI���� ���̺귯��
using UnityEngine.SceneManagement;  // �� ���� ���� ���̺귯��

public class GameManager : MonoBehaviour
{

    public GameObject gameoverText;   //  ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    // ���� ����ϴ� ����� �ִ�.
    // ������� �ִ�.
    // �� �ѹ��� ����� ��� ���� ����ϴ°� ����.
    // ���� ����Ѵٸ� ���̺귯���� ����ϰڴٰ� ��ø� �ϰ� ����Ȯ���� �Ǽ� ������..
    public Text timeText;             //  ���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText;           //  �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime;        //  ���� �ð�
    private bool isGameover;          //  ���� ���� ����


    // Start is called before the first frame update
    void Start()
    {
        // ���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0;
        isGameover = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        
        // ���ӿ����� �ƴ� ����
        if (!isGameover)
        {
            // ���� �ð� ����
            surviveTime += Time.deltaTime;

            // ������ ���� �ð���  timeText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            timeText.text = "Time:" + (int)surviveTime;
        }

        else
        {
            // ���ӿ��� ���¿��� RŰ�� ���� ���
            if (Input.GetKeyDown(KeyCode.R))
            {

                // SampleScene ���� �ε�
                SceneManager.LoadScene("SampleScene");
                // SceneManager.LoadScene(0);  >>>>>>>>  �͵��� ������ �ε��ϴ� ���
                // SampleScene�� �������� �Ѵ�. 

            }
        }


    }

    // ���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {
        // ���� ���¸� ���ӿ��� ���·� ����
        isGameover = true;

        // ���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
        gameoverText.SetActive(true);


    }


}
