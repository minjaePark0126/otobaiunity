using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text text;//점수를 표시하는 Text를 text에서 받아온다
    public static int score;
    public static int coinAmount;

    // Start is called before the first frame update
    

    public GameObject restartBtn;

    void Start()
    {
        score = 0;//점수 0으로 초기화
        text = GetComponent<Text>();//Text컴포넌트를 가져온다
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
