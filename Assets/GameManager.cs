using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
<<<<<<< .merge_file_a07148
    public Text text;//������ ǥ���ϴ� Text�� text���� �޾ƿ´�
    public static int score;
    public static int coinAmount;

    // Start is called before the first frame update
    

    public GameObject restartBtn;

    void Start()
    {
        score = 0;//���� 0���� �ʱ�ȭ
        text = GetComponent<Text>();//Text������Ʈ�� �����´�
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString();


    }
    
    public void onDie()
    {
        Time.timeScale = 0;
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
=======
    Text text;
    public int score;
    public static int coinAmount;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Score.coinAmount += 5;//5���� ����
        Destroy(gameObject);//������ �������!
        Sound.SoundPlay();

        if (collision.gameObject.tag == "Co")//���ε����� Co�±� ��ŵ��
        {
            collision.gameObject.SetActive(false);
        }


        // Start is called before the first frame update
        void Start()
        {
            score = 0;
            text = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            text.text = coinAmount.ToString();
        }







>>>>>>> .merge_file_a10420
    }
}
