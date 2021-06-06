using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
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
    }
}
