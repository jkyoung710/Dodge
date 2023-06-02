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
            // �� �ڵ����� ��Ȱ��ȭ�� ��ü�� �����̼��� ��Ȱ���Ǵ� ������ �����̼� ���� ���� ü�� ����
            // ex) rotation (0,48,0)���� ��Ȱ��ȭ�� ��Ȱ��ȭ��  rotation (0,48,0)���� ���� ����. �̹� 48�� ȸ�����·� ������
            // �ش� ������Ʈ�� Ȱ��ȭ �� �������� ȸ�� ������ ���Ѵٸ� ���
                        
        }

        // Invoke("testtime", 3f);

    }
    // -------------------------------------  invoke ��� �κ� 
    //public void testtime()
    //{
    //    Debug.Log("3������");
    //}

    void Update()
    {
        

        if (!isGameover)
        {
            // �����ð� ����
            surviveTime += Time.deltaTime;
            // ������ ���� �ð��� timeText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            timeText.text = "Time :" + (int)surviveTime;

        }

        else
        {
            
            // ���ӿ����� ���¿��� R Ű�� ���� ���
            if (Input.GetKeyDown(KeyCode.R))
            {
                
                // SampleScene ���� �ε�
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

        // bool ��(���� : isPhase03 == true)�� ������ if���� �����Ͽ� ���� ����ߴ� bool ������ �̿��� ������ ������ �̿��� ���� ����

        if (surviveTime >= 20f) 
        {
            chil2.gameObject.SetActive(false);
        }

        // ����� �Ѿ���� bool ���� �������� �Ͽ� ������Ʈ�� ��Ȱ��ȭ

        if (surviveTime >= 20f)
        {
            chil3.gameObject.SetActive(true);
        }


        if (surviveTime >= 30f)
        {
            // chil3.gameObject.SetActive(false);
        }


    }


    // ���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {
        // ���� ���¸� ���ӿ��� ���·� ��ȯ
        isGameover = true;
        // ���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
        gameoverText.SetActive(true);
        //�׾����� ����ī��Ʈ ǥ��
        deadCount++;
        deadText.text = "Dead :" + deadCount;



        // BestTime Ű�� ����� ���������� �ְ� ��� ��������
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // ���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if (surviveTime > bestTime)
        {
            // �ְ� ��� ���� ���� ���� �ð� ������ ����
            bestTime = surviveTime;
            // ����� �ְ� ����� BestTime Ű�� ����
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        // �ְ� ����� recordText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
        recordText.text = "BestTime: " + (int)bestTime;

    }


//    ������ ������ �ܰ踦 ��Ÿ����.
//1�ܰ� redspawner �������                      v 
//2�ܰ� orangespawner ǳ�� (�ѹ���)              v
//3�ܰ� yellowspawner ������� (���ι��� �߰�)   v
//4�ܰ� greenspawner ǳ�� (4���� ���� �ݴ� �ݺ�)
//5�ܰ� bluespawner �������(�밢���� �߰�) (ƨ���)      
//6�ܰ� Indigospawner ǳ��(�ѹ���, 90ȸ�� 4������)
//7�ܰ� violetspawner �����Ѿ�

//�ð����� �ܰ踦 ����� 30�ʸ� ��Ƽ�� ���� ���������� �̵�
//�����ð��� ���Ѿ��� 10�ʷ� ����







}
