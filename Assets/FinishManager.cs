using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishManager : MonoBehaviour

{

    public TextMesh finishScoreObj;            //Text 변수 선언

    public TextMesh bestScoreObj;               //Text 변수 선언



    int finishScore;                           //int 변수 선언

    int bestScore;                              //int 변수 선언

    /*int text;
    public GameObject newImg;
    public Text scoreText;
    static public int score = 0;*/

    
    void Start()

    {

        Debug.Log("++++++++++++++++++++");


        
        //HasKey는 스트링형 키값을 통해 데이터가 참, 거짓 존재하는지 알려줌.

        if (PlayerPrefs.HasKey("finishScore"))

        {

            //int 값에 GetInt함수 사용하여 데이터 불러오기.

            finishScore = PlayerPrefs.GetInt("finishScore");    //키값 beforeSocre의 PlayerPrefs를 int형 변수 저장

            finishScoreObj.text = finishScore.ToString();

            Debug.Log("finishScore :: " + finishScore);

        }
        /*if (score > PlayerPrefs.GetInt("bestScore"))
        {
            PlayerPrefs.SetInt("BestScore", score);
            newImg.SetActive(true);
        }
        else if (score <= PlayerPrefs.GetInt("BestScore"))
        {
            newImg.SetActive(false);
        }

       
    }
}*/

    
    //새로운 점수 판에 랜덤 값 주기

    bestScore = Random.Range(1, 10);

        bestScoreObj.text = bestScore.ToString();

        Debug.Log("bestScore :: " + bestScore);



        PlayerPrefs.SetInt("finishScore", bestScore);  //highScore라는 키값에 newScore 값 지정하기.

        PlayerPrefs.Save();                                   //지정한 데이터 저장하기.

    }

}
/*public class FinishManager : MonoBehaviour
{
    public TextMesh Score;

    //public TextMesh BestScore;
    public TextMesh finishScoreText;
    public TextMesh bestScroeText;
    //public Text scoreText;

    public GameObject newImg;
    private string text;

    static public int score = 0;
    static public int bestScore = 0;

    /*public void PlayBtn()
    {

        void OnMouseDown()
        {
            GameManager.score = 0;
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void Game()
    {
    if (score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", score);
            newImg.SetActive(true);
        }
        else if (score <= PlayerPrefs.GetInt("BestScore"))
{
    newImg.SetActive(false);
}

finishScoreText.text = score.ToString();
bestScroeText.text = PlayerPrefs.GetInt("BestScore").ToString();
    }
    /* public void OnEnable()
    {
        Score.text = Score.ToString();//score을 받아옴
        
        if(GameManager.bestScore<GameManager.score)//만약 GameManager의 bestScore가 현재 스코어보다 낮다면
        {
            GameManager.bestScore = GameManager.score;//점수 갱신
            newImage.SetActive(true);//new이미지 띄움
        }
        else
        {
            newImage.SetActive(false);//점수 갱신 안됐으면 new이미지 안 띄움
        }
        BestScore.text = GameManager.bestScore.ToString();//BestScore도 GameManager의 스코어를 받아옴
    }*/
//SampleScene을 불러올거고 현재 score은 0으로 만들거다
//첫화면 로드, 점수 초기화


